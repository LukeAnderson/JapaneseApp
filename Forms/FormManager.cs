using System.Collections.Generic;
using System.Windows.Forms;

namespace JapaneseApp.Forms
{
    public class FormManager
    {
        public List<Form> FormsList { get; set; }
        private Form CurrentForm { get; set; }

        public FormManager()
        {
            FormsList = new List<Form>
            {
                new Form1(this),
                new Form2(this)
            };

            CurrentForm = FormsList[0];
            CurrentForm.Show();
        }




        public void changeForm(Form formToChangeTo)
        {
            formToChangeTo.Size = CurrentForm.Size;
            formToChangeTo.Width = CurrentForm.Width;
            formToChangeTo.Location = CurrentForm.Location;



            formToChangeTo.Opacity = 100;
            formToChangeTo.Show();


            CurrentForm.Opacity = 0;
            CurrentForm.Hide();




            CurrentForm = formToChangeTo;
        }

        public void Exit()
        {
            Application.Exit();
        }
    }
}
