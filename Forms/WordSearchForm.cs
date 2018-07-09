using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using JapaneseApp.UserControls;

namespace JapaneseApp
{
    public partial class WordSearchForm : Form
    {
        static JsonController jsonController = new JsonController();
        RootObject jsonObject;


        FlickrApi flickrApi;

        List<RichTextBox> richTextBoxes;

        private string suggestedSearch;



        private CefSharpBrowser cefBrowser;
        private ChromiumWebBrowser chromeBrowser;


        private Dictionary<Button, Control> sidebarButtonsAndPages;


        public WordSearchForm()
        {
            InitializeComponent();

            flickrApi = new FlickrApi();

     
            //put all of the RichTextboxes into a list
            richTextBoxes = new List<RichTextBox>();
            richTextBoxes.AddRange(Controls.OfType<RichTextBox>());

            //subscribe to button press events
            flickrImageSearch.SearchButtonPressed += new EventHandler(OnFlickrImageSearchButton_Click);
            jishoSearch.SearchButtonPressed += new EventHandler(searchButton_Click);
            jishoSearch.NextButtonPressed += new EventHandler(nextButton_Click);
            sideBar1.buttonClicked += new EventHandler(sidebarButton_Click);

            //subscribe to dataGridView changedCell
            jishoDataGridView.changedCell += new EventHandler(OnJishoDataGridViewChangedCell);

            //make browser
            cefBrowser = new CefSharpBrowser();
            cefBrowser.Dock = DockStyle.Fill;
            chromeBrowser = cefBrowser.chromeBrowser;
            pagePanel.Controls.Add(cefBrowser);

            setupSidebar();
        }

        private void OnJishoDataGridViewChangedCell(object sender, EventArgs e)
        {
            EnhanceTextBox.Text = jishoDataGridView.GetCurrentCellText();
        }

        #region Button Clicks

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search(jishoSearch.GetSearchText());

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
                if (flickrImageSearch.onButtonChecked())
                {
                    flickrImageSearch.SetImageSearchText(suggestedSearch);
                    FlickrImage.SearchImage(suggestedSearch);
                }
            }
        }
        private void OnFlickrImageSearchButton_Click(object sender, EventArgs e)
        {
            FlickrImage.SearchImage(flickrImageSearch.GetImageSearchText());
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
            jishoDataGridView.SetFont(fd.Font);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (backTableLayoutPanel.ColumnStyles[0].Width == 100)
                backTableLayoutPanel.ColumnStyles[0].Width = 0;
            else
                backTableLayoutPanel.ColumnStyles[0].Width = 100;
        }


        #endregion

        #region Text Changes

        public void UpdateText()
        {

            //update data grid view 
            jishoDataGridView.AddRows(jsonController.getRows());
            jishoDataGridView.UpdateCurrentCell();

            //update englishDefinition && enhance text boxes
            EnhanceTextBox.Text = jishoDataGridView.GetCurrentCellText();
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

        public string printEnglishDefinitions()
        {
            return printList("English Words:\n", jsonController.getEnglishDefinitions());
        }
        public string printList(string baseSting, List<string> list)
        {
            foreach (string str in list)
                baseSting += str + "\n";
            return baseSting;
        }

        #endregion

        //Search using jisho.org & flickr apis
        public void Search(string searchText)
        {
            jsonObject = jsonController.setJson(searchText);
            FlickrImage.SearchImage(searchText);
        }



        /*pagination*/
        private void setupSidebar()
        {
            sidebarButtonsAndPages = new Dictionary<Button, Control>();
            for (int i = 0; i < sideBar1.sidebar.Controls.Count; i++)
            {
                sidebarButtonsAndPages.Add((Button)sideBar1.sidebar.Controls[i], pagePanel.Controls[i]);
            }
        }

        private void sidebarButton_Click(object sender, EventArgs e)
        {
            Control pageToMakeVisible = sidebarButtonsAndPages[sideBar1.previousButton];//last button that was pressed
            Control pageToMakeInvisible = sidebarButtonsAndPages[sideBar1.currentButton];//current button that was pressed

            if (pageToMakeVisible == pageToMakeInvisible) return;

            //EnglishDefinitionTextBox.Text = "visible: " + pageToMakeVisible.Name + "\ninvisible: " + pageToMakeInvisible.Name;
            pageToMakeVisible.Visible = true;
            pageToMakeInvisible.Visible = false;
        }


        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            cefBrowser.Close();
        }
    }
}