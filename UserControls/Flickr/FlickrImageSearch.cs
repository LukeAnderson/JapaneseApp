using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseApp
{
    public partial class FlickrImageSearch : UserControl
    {

        public event EventHandler SearchButtonPressed = delegate { };
        public FlickrImageSearch()
        {
            InitializeComponent();

            flickrImageSearchButton.Click += new EventHandler(flickrImageSearchButton_Click);//when search button is press notify subscribers

        }

        private void flickrImageSearchButton_Click(object sender, EventArgs e)
        {
            SearchButtonPressed(this, new EventArgs());
        }


        public RadioButton GetChecked()
        {
            return onRadioButton.Checked ? onRadioButton : offRadioButton;
        }

        public bool onButtonChecked()
        {
            return onRadioButton.Checked;
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
    }
}
