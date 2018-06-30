using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JapaneseApp.Forms
{
    public class FormManager
    {
        public List<Form> FormsList { get; set; }
        public Form CurrentForm { get; set; }

        public event EventHandler formManagerNearlyInitialized = delegate { };
        public event EventHandler form2Activate = delegate { };





        public List<string> sidebarButtonsNames { get; set; }



        public FormManager()
        {

            //make the list of forms
            FormsList = new List<Form>();


            Form wsf = new WordSearchForm(this);
            wsf.Name = "Word Search";
            FormsList.Add(wsf);


            Form f2 = new Form2(this);
            f2.Name = "DJT Guide";
            FormsList.Add(f2);


            formManagerNearlyInitialized(this, new EventArgs());

            CurrentForm = FormsList[0];
            CurrentForm.Show();
        }



        //given a form to change to changes to that form
        public void changeForm(string formToChangeToName)
        {
            if (formToChangeToName == CurrentForm.Name)
                return;
            Form formToChangeTo = FormsList.Find(x => x.Name == formToChangeToName);

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
