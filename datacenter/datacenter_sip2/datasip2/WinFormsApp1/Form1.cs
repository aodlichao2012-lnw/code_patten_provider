using datacenter.API_providers;
using datasip2.Error_provider;
using datasip2.Isvaild_model;
using SelfCheckHybrid.Models.Sip2;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string message = string.Empty;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                message = Valid_provider.Instances.isvaild(new PatronInformation(), textBox1.Text, ref message ).ToString();
                MessageBox.Show("" + message);
                PatronInformation c = new PatronInformation();
                object a = new PatronInformation()
                {
                    PatronID = "77777"
                };
        
                a.GetType().GetProperty("PatronID")!.SetValue( a, "ddddd");
                c.PatronID = a.ToString();
                MessageBox.Show(c.PatronID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+Error_providers.Instances.CustomsExceptions(ex));
            }
          
        }
    }
}