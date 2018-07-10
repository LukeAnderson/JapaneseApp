using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseApp.UserControls
{
    public partial class JishoSearch : UserControl
    {

        public event EventHandler SearchButtonPressed = delegate { };
        public event EventHandler NextButtonPressed = delegate { };
        public JishoSearch()
        {
            InitializeComponent();

            searchButton.Click += new EventHandler(OnSearchButton_Click);//OnSeachButton press notify subscribers
            nextButton.Click += new EventHandler(OnNextButton_Click);//OnSeachButton press notify subscribers
        }

        private void OnSearchButton_Click(object sender, EventArgs e)
        {
            SearchButtonPressed(this, new EventArgs());
        }

        private void OnNextButton_Click(object sender, EventArgs e)
        {
            NextButtonPressed(this, new EventArgs());
        }

        public string GetSearchText()
        {
            return searchTextbox.Text;
        }


        public void searchTextbox_GotFocus(Object sender, EventArgs e)
        {
            searchTextbox.Text = "";
            searchTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void labelAndBarTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
