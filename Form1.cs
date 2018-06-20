using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using KanaConverterLib;

namespace JapaneseApp
{
    public partial class Form1 : Form
    {
        static JsonController jsonController = new JsonController();
        RootObject jsonObject;


        FlickrApi flickrApi;

        List<RichTextBox> richTextBoxes;
        List<RadioButton> imageQualityRadioButtons;

        public Form1()
        {
            InitializeComponent();
            
            flickrApi = new FlickrApi();

            //put all of the RichTextboxes into a list
            richTextBoxes = new List<RichTextBox>();
            foreach (Control control in Controls)
            {
                if(control.GetType() == typeof(RichTextBox))
                    richTextBoxes.Add((RichTextBox)control);
            }

            //put all the imageQualityRadioButtons into a list
            imageQualityRadioButtons = new List<RadioButton>();
            foreach (Control control in ImageQualityTableLayoutPanel.Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                    imageQualityRadioButtons.Add((RadioButton)control);
            }


            imageQualityRadioButtons.Add(thumbnailRadioButton);
            imageQualityRadioButtons.Add(smallRadioButton);
            imageQualityRadioButtons.Add(mediumRadioButton);
        }

        #region Button Clicks

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search(searchTextbox.Text);

            if (jsonObject == null)//the search yeilded 0 results -> can't update text
            {
                EnglishDefinitionTextBox.Text = "No results for search";
                return;
            }
            else
            {
                UpdateText();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (jsonObject == null)//the search yeilded 0 results -> can't call Next();
            {
                EnglishDefinitionTextBox.Text = "No results for search";
                return;
            }
            else
            {
                jsonController.nextResult();
                UpdateText();
                if (onRadioButton.Checked)
                {
                    SearchImage(suggestedSearch);
                }
            }
        }

        private void flickrImageSearchButton_Click(object sender, EventArgs e)
        {
            SearchImage(imageTagSearchBox.Text);
        }

        #endregion

        #region StripMenuItems

        private void englishDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            EnglishDefinitionTextBox.Font = fd.Font;
        }

        private void japaneseDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            japaneseTextBox.Font = fd.Font;
        }

        #endregion

        #region RadioButtons

        #region imageQuality RadioButtons

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeImageQuality(smallRadioButton);
        }

        private void thumbnailRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeImageQuality(thumbnailRadioButton);
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeImageQuality(mediumRadioButton);
        }

        public void ChangeImageQuality(RadioButton radioButton)
        {
            string imageLocation = flickrApi.Search(flickrApi.lastSearchString, radioButton.Name);

            if (imageLocation.Equals("noImage"))
                pictureBox1.Image = Properties.Resources.No_image_available; 

            else
            {
                pictureBox1.ImageLocation = imageLocation;
                pictureBox1.Load();
            }
        }

        #endregion

        #endregion

        #region Text Changes

        public void searchTextbox_GotFocus(Object sender, EventArgs e)
        {
            searchTextbox.Text = "";
            searchTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        public void ClearText()
        {
            foreach (RichTextBox richTextBox in richTextBoxes)
            {
                richTextBox.Clear();
            }
        }

        string suggestedSearch = "";

        public void UpdateText()
        {
            japaneseTextBox.Text = printJapaneses();
            EnglishDefinitionTextBox.Text = printEnglishDefinitions();

            /*
             * set suggestedSearchTextBox to the second line of EnglishDefinitionTextBox
             * E.g.
             * EnglishDefinitonsTextBox.Text = "English Definitions:\nDog" -> suggestedSearchTextBox.Text = "Dog"
             */
            StringReader strReader = new StringReader(EnglishDefinitionTextBox.Text);
            strReader.ReadLine();
            suggestedSearch = strReader.ReadLine();
        }

        public string printJapaneses()
        {
            return printList("Japanese:\n", jsonController.getJapaneses());
        }

        public string printEnglishDefinitions()
        {
            return printList("English Definitions:\n", jsonController.getEnglishDefinitions());

        }

        public string printList(string baseSting, List<string> list)
        {
            foreach (string str in list)
                baseSting += str + "\n";
            return baseSting;
        }

        #endregion

        #region Searching internet using APIS

        public void Search(string searchText)
        {
            jsonObject = jsonController.setJson(searchText);
            SearchImage(searchText);
        }

        public void SearchImage(string searchText)
        {            
            imageTagSearchBox.Text = searchText;

            RadioButton selectedImageQualityRadioButton = imageQualityRadioButtons.Find(x => x.Checked);

            //imageLocation is a url of image or if no results imageLocation = "noImage"
            string imageLocation = flickrApi.Search(searchText, selectedImageQualityRadioButton.Name);

            if (imageLocation.Equals("noImage"))
                pictureBox1.Image = Properties.Resources.No_image_available;
            else
            {
                pictureBox1.ImageLocation = imageLocation;
                pictureBox1.Load();
            }
        }
        #endregion
    }
}