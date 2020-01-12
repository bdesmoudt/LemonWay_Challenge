using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lemonay_WinForm
{
    public partial class CalculForm : Form
    {
        public CalculForm()
        {
            InitializeComponent();
        }

        private async void Calcul_Click(object sender, EventArgs e)
        {
            Resultat_TextBox.ResetText();
            int n = 0;
            string result = "";

            if (!Int32.TryParse(FiboNumber.Text, out n))
            {
                MessageBox.Show("Erreur : Veuillez renseigner une valeur numérique");
                return;
            }
            BusyForm frm = new BusyForm();
            ServiceFiboXml.ServiceSoapClient client = new ServiceFiboXml.ServiceSoapClient();

            await Task.Run(new Action(() =>
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        frm.ShowDialog();
                    }));

                    result = client.Fibonacci(n).ToString();
                }
                )).ContinueWith(new Action<Task>(task =>
                {
                    frm.Close();
                }), TaskScheduler.FromCurrentSynchronizationContext());

            Resultat_TextBox.Text = result;
            MessageBox.Show(result);
        }

        private async void Convert_Button_Click(object sender, EventArgs e)
        {
            string result = "";
            BusyForm frm = new BusyForm();
            ServiceFiboXml.ServiceSoapClient client = new ServiceFiboXml.ServiceSoapClient();

            await Task.Run(new Action(() =>
            {
                this.BeginInvoke(new Action(() =>
                {
                    frm.ShowDialog();
                }));

                result = client.XmlToJson(Xml_TextBox.Text);
            }
                )).ContinueWith(new Action<Task>(task =>
                {
                    frm.Close();
                }), TaskScheduler.FromCurrentSynchronizationContext());

            Json_TextBox.Text = result;
            MessageBox.Show(result);
        }
    }
}

