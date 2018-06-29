using JapaneseApp.Forms;
using System.Windows.Forms;

namespace JapaneseApp
{
    public partial class Form2 : Form
    {
        FormManager formManager;
        public Form2(FormManager formManager)
        { 
            InitializeComponent();
            this.formManager = formManager;

            
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            formManager.Exit();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            formManager.changeForm(formManager.FormsList[0]);//change to form1
        }
    }
}
