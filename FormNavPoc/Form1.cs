using FormNavPoc.Services;

namespace FormNavPoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form2 form2 = new Form2();
            ////this.Close();

            //for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            //{
            //    Application.OpenForms[i].Close();
            //}

            //form2.Show();
            NavigationService.ShowForm("Form2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
