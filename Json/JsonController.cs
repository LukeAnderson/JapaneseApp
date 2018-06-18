using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace JapaneseApp
{
    class JsonController
    {
        WebClient webClient;
        private int currentResult;

        RootObject json;

        public JsonController()
        {
            json = null; 

            webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            currentResult = 0;
        }

        /* Makes list of strings 
         * does so by calling a function that gets a single string at an index
         */
        private List<string> getMultiple(int maxIndex, Func<int, string> JsonGetStringAtIndex)
        {
            if (json == null || maxIndex < 0 || JsonGetStringAtIndex == null)
                throw new ArgumentException();
          
            List<string> list = new List<string>();
            for (int i = 0; i < maxIndex; i++)
                list.Add(JsonGetStringAtIndex(i));
            return list;
        }
    
        #region Japanese

        #region Japanese Words

        public string getWord(int wordIndex)
        {
            if (wordIndex < numOfJapaneses())
            {
                return json.data[currentResult].japanese[wordIndex].word;
            }
            else
            {
                throw new IndexOutOfRangeException();//wordIndex
            }
        }

        public List<string> getWords()
        {
            return getMultiple(numOfJapaneses(), getWord);
        }

        #endregion

        #region Japanese Readings

        public string getReading(int readingIndex)
        {
            if (readingIndex < numOfJapaneses())
            {
                return json.data[currentResult].japanese[readingIndex].reading;
            }
            else
            {
                throw new IndexOutOfRangeException();//readingIndex
            }
        }

        public List<string> getReadings()
        {
            return getMultiple(numOfJapaneses(), getReading);
        }

        #endregion

        #region Japanese (get both word and reading)

        public string getJapanese(int japaneseIndex)
        {
            if (japaneseIndex < numOfJapaneses())
            {
                string kanji = getWord(japaneseIndex);
                if (string.IsNullOrWhiteSpace(kanji))
                {
                    return getReading(japaneseIndex);
                }

                return kanji + "\t\t" + getReading(japaneseIndex);
            }
            else
            {
                return "error japanese index out of bounds";
            }
        }

        public List<string> getJapaneses()
        {
            return getMultiple(numOfJapaneses(), getJapanese);
        }

        #endregion

        public int numOfJapaneses()
        {
            if(json == null)
            {
                throw new NullReferenceException();
            }
            try
            {
                return json.data[currentResult].japanese.Count;
            }catch (ArgumentOutOfRangeException)
            {
                return -1;
            }
        }
        #endregion

        #region english definitions

        public string getEnglishDefiniton(int sensesIndex, int englishDefinitionsIndex)
        {
            return json.data[currentResult].senses[sensesIndex].english_definitions[englishDefinitionsIndex];
        }

        public List<string> getEnglishDefinitions()
        {
            List<string> definitions = new List<string>();
            for (int j = 0; j < numOfSenses(); j++)
            {
                for (int i = 0; i < numOfDefinitions(j); i++)
                    definitions.Add(getEnglishDefiniton(j, i));

            }
            return definitions;
        }

        #endregion

        #region Jisho.org Api

        public string Search(string query)
        {
            return webClient.DownloadString("https://jisho.org/api/v1/search/words?keyword=\"" + query.ToLower() + "\"");
        }

        public RootObject setJson(string query)
        {
            json = JsonConvert.DeserializeObject<RootObject>(Search(query));//use Newtonsoft.json to convert json from web to RootObject
            if (numOfResults() == 0)
                json = null;
            currentResult = 0;
            return json;
        }

        #region getting num of results 

        public int numOfSenses()
        {
            return json.data[currentResult].senses.Count;
        }

        public int numOfDefinitions(int senseIndex)
        {
            return json.data[currentResult].senses[senseIndex].english_definitions.Count;
        }

        public int numOfResults()
        {
            return json.data.Count;
        }

        #endregion

        /*update to next result
         * E.g
         * json.data[currentResult] -> json.data[currentResult+1]
         * if at last result nextResult -> currentResult = 0
         */
        public void nextResult()
        {
            if (currentResult < numOfResults() - 1)
                currentResult++;
            else//at last result nextResult -> reset to 0.
            {
                currentResult = 0;
            }
        }

        #endregion
    }
}