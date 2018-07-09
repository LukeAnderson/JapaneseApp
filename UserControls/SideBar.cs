using System;
using System.Windows.Forms;

namespace JapaneseApp.UserControls
{
    public partial class SideBar : UserControl
    {
        public Button currentButton { get; set; }
        public Button previousButton { get; set; }


        public TableLayoutPanel sidebar { get; private set; }

        public event EventHandler buttonClicked = delegate { };
        public SideBar()
        {
            InitializeComponent();

            sideBarWordSearchButton.Click += new EventHandler(Button_Click);
            sideBarDjtGuideButton.Click += new EventHandler(Button_Click);
            
            sidebar = sideBarLayoutPanel;
            currentButton = sideBarWordSearchButton;
            previousButton = sideBarWordSearchButton;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            previousButton = currentButton;
            currentButton = ((Button)sender);

            buttonClicked(this, new EventArgs());
        }
    }
}
