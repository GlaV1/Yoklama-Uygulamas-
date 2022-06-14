using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoklama_app.Forms
{
    public partial class MesajKisayol : Form
    {
        public MesajKisayol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        FormIslem1 f = new FormIslem1();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            if (İsimSoyisim.Text == "Ömer Şahin 10-C")
            {
                if (ch1.Checked || ch2.Checked || ch3.Checked || ch1.Checked && ch2.Checked && ch3.Checked)
                {
                    MessageBox.Show("Test");
                    SmsApiService smsApi = new SmsApiService();
                    smsApi.SmsSender(f.omerlabel1.Text, İsimSoyisim.Text);//2. yer(isimsoyim.text) yanlış oraya chboxlardaki seçilen yazıların gelmesi lazım 
                }
            }
            
        }
    }
}
