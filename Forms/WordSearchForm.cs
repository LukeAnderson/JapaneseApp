using JapaneseApp.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace JapaneseApp
{
    public partial class WordSearchForm : Form
    {
        static JsonController jsonController = new JsonController();
        RootObject jsonObject;


        FlickrApi flickrApi;

        List<RichTextBox> richTextBoxes;
        List<RadioButton> imageQualityRadioButtons;

        List<Button> sidebarButtons;

        String name = "Word Search";


        FormManager formManager;
        public WordSearchForm(FormManager formManager)
        {
            InitializeComponent();

            this.formManager = formManager;

            flickrApi = new FlickrApi();

            //put all of the RichTextboxes into a list
            richTextBoxes = new List<RichTextBox>();
            richTextBoxes.AddRange(Controls.OfType<RichTextBox>());

            //put all the imageQualityRadioButtons into a list
            imageQualityRadioButtons = new List<RadioButton>();
            imageQualityRadioButtons.AddRange(ImageQualityTableLayoutPanel.Controls.OfType<RadioButton>());


            //get all the sideButtons
            formManager.formManagerNearlyInitialized += new EventHandler(OnformMangagerNearlyInitialized);


          






        }

        //create sidebar buttons foreach form
        private void OnformMangagerNearlyInitialized(object sender, EventArgs e)
        {
            foreach (Form form in formManager.FormsList)
            {
                Button button = new Button();

                button.Text = form.Name;
                button.BackColor = SystemColors.ButtonFace;
                button.Dock = DockStyle.Fill;
                button.Click += OnClickChangeForm;

                sidebarTableLayoutPanel.Controls.Add(button);
            }
        }
        //when one of the sidebar buttons is clicked change to that form
        private void OnClickChangeForm(object sender, EventArgs e)
        {
            formManager.changeForm(((Button)sender).Text);
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
            //  japaneseTextBox.Font = fd.Font;
            dataGridView1.Font = fd.Font;

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
            dataGridView1.Rows.Clear();

            List<string[]> rows = jsonController.getRows();
            foreach (string[] row in rows)
                dataGridView1.Rows.Add(row);


            for (int colIndex = 0; dataGridView1.CurrentCell.Value == null; colIndex++)
            {
                if (colIndex == 4)
                    throw new InvalidDataException();
                dataGridView1.CurrentCell = dataGridView1[++colIndex, 0];
            }
            EnhanceTextBox.Text = dataGridView1.CurrentCell.Value.ToString();

            japaneseTextBox.Text = printJapanesesWithPartsOfSpeech();
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
            return printList("English Words:\n", jsonController.getEnglishDefinitions());
        }

        public string printJapanesesWithPartsOfSpeech()
        {
            return printList("Japanese Words:\n", jsonController.getJapaneseWithPartOfSpeech());
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                EnhanceTextBox.Text = dataGridView1.CurrentCell.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EnglishDefinitionTextBox.Text = button.Name;
            //  formManager.changeForm(formManager.FormsList[1]);//change to form2
        }

        private void Exit(object sender, EventArgs e)
        {
            formManager.Exit();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (backTableLayoutPanel.ColumnStyles[0].Width == 100)
                backTableLayoutPanel.ColumnStyles[0].Width = 0;
            else
                backTableLayoutPanel.ColumnStyles[0].Width = 100;
        }


  
    }
}