using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormNavPoc.Services
{
    internal static class NavigationService
    {
        private static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
                item.Close();
            }
            //foreach (Form item in Application.OpenForms)
            //{
            //    item.Close();
            //}
        }

        public static void ShowForm(string formName)
        {
            CloseAllForms();

            Form form = formName switch
            {
                "Form1" => new Form1(),
                "Form2" => new Form2(),
                _ => throw new ArgumentException("Invalid form name.", nameof(formName)),
            };
            form.Show();

            //Type t = Type.GetType(formName);
            //if (t == null)
            //{
            //    throw new ArgumentException("Type not found.", nameof(formName));
            //}
            //Activator.CreateInstance(t);
        }
    }
}
