using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseApp
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            Size = form1.Size;
            Width = form1.Width;
        }

        private void FormClosingNow(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
