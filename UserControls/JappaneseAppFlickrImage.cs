using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JapaneseApp.UserControls
{
    public partial class JappaneseAppFlickrImage : UserControl
    {
        private List<RadioButton> imageQualityRadioButtons;
        private FlickrApi flickr;

        public JappaneseAppFlickrImage()
        {
            InitializeComponent();

            flickr = new FlickrApi();

            //put all the imageQualityRadioButtons into a list
            imageQualityRadioButtons = new List<RadioButton>();
            imageQualityRadioButtons.AddRange(imageQualityTableLayoutPanel.Controls.OfType<RadioButton>());
        }

        public void SearchImage(string searchText)
        {
            RadioButton selectedImageQualityRadioButton = imageQualityRadioButtons.Find(x => x.Checked);

            //imageLocation is a url of image or if no results imageLocation = "noImage"
            string imageLocation = flickr.Search(searchText, selectedImageQualityRadioButton.Name);

            if (imageLocation.Equals("noImage"))
                pictureBox.Image = Properties.Resources.No_image_available;
            else
            {
                pictureBox.ImageLocation = imageLocation;
                pictureBox.Load();
            }
        }
    }
}
