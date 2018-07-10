using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseApp.UserControls.Flickr
{
    public partial class Flickr : UserControl
    {
        private List<RadioButton> imageQualityRadioButtons;
        private FlickrApi flickrApi;


        public event EventHandler SearchButtonPressed = delegate { };
        public Flickr()
        {
            InitializeComponent();

            flickrApi = new FlickrApi();

            //put all the imageQualityRadioButtons into a list
            imageQualityRadioButtons = new List<RadioButton>();
            imageQualityRadioButtons.AddRange(imageQualityTableLayoutPanel.Controls.OfType<RadioButton>());
        }

        public void SearchImage(string searchText)
        {
            RadioButton selectedImageQualityRadioButton = imageQualityRadioButtons.Find(x => x.Checked);

            //imageLocation is a url of image or if no results imageLocation = "noImage"
            string imageLocation = flickrApi.Search(searchText, selectedImageQualityRadioButton.Name);

            if (imageLocation.Equals("noImage"))
                pictureBox.Image = Properties.Resources.No_image_available;
            else
            {
                pictureBox.ImageLocation = imageLocation;
                pictureBox.Load();
            }
        }

        private void flickrImageSearchButton_Click(object sender, EventArgs e)
        {
            SearchButtonPressed(this, new EventArgs());
        }

        public string GetSearch()
        {
            return imageSearchRichTextBox.Text;
        }

        public void SetImageSearchText(string text)
        {
            imageSearchRichTextBox.Text = text;
        }

        public string GetImageSearchText()
        {
            return imageSearchRichTextBox.Text;
        }

        public bool onButtonChecked()
        {
            return onRadioButton.Checked;
        }


    }
}
