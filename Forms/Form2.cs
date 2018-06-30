using JapaneseApp.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JapaneseApp
{
    public partial class Form2 : Form
    {
        String name = "DJT Guide";

        FormManager formManager;

        public Form2(FormManager formManager)
        { 
            InitializeComponent();
            this.formManager = formManager;

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



        private void Exit(object sender, FormClosingEventArgs e)
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
