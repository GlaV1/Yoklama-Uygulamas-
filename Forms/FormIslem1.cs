using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace yoklama_app.Forms
{
    public partial class FormIslem1 : Form
    {
        public FormIslem1()
        {
            InitializeComponent();
        }
        private void FormIslem1_Load(object sender, EventArgs e)
        {
            LoadTheme();
            
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = temarenk.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = temarenk.SecondaryColor;
                }
            }


        }

        private void rjToggleButton7_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton2.Checked)
            {
                sinan1.color = Color.Red;
            }
            else
            {
                sinan1.color = Color.Green;
            }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                utku1.color = Color.Red;
            }
            else
            {
                utku1.color = Color.Green;
            }
        }

        private void rjToggleButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton9.Checked)
            {
                fatih1.color = Color.Red;
            }
            else
            {
                fatih1.color = Color.Green;
            }
        }

        private void rjToggleButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton3.Checked)
            {
                deniz1.color = Color.Red;
            }
            else
            {
                deniz1.color = Color.Green;
            }
        }
        private void ömer1_Click(object sender, EventArgs e)
        {
           
        }




        //okulda yoktur butonu kodları
        private void omertooglebuton_CheckedChanged(object sender, EventArgs e)
        {

            if (omertooglebuton.Checked)
            {
                ömer1.color = Color.Red;
                SmsApiService smsApi = new SmsApiService();
                smsApi.SmsSender(omerlabel1.Text, omerlabel2.Text);
            }
            else
            {
                ömer1.color = Color.Green;
            }
        }
        private void rjToggleButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (oguztooglebuton.Checked)
            {
                oguz1.color = Color.Red;
                SmsApiService smsApi = new SmsApiService();
                smsApi.SmsSender(oguzlabel1.Text, oguzlabel2.Text);
            }
            else
            {
                oguz1.color = Color.Green;
            }
        }
        private void Semihtooglebuton_CheckedChanged(object sender, EventArgs e)
        {
            if (Semihtooglebuton.Checked)
            {
                semih1.color = Color.Red;
                SmsApiService smsApi = new SmsApiService();
                smsApi.SmsSender(semihlabel1.Text, semihlabel2.Text);

            }
            else
            {
                semih1.color = Color.Green;
            }
        }
        private void rjToggleButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton4.Checked)
            {
                serhat1.color = Color.Red;
                SmsApiService smsApi = new SmsApiService();
                smsApi.SmsSender(serhatlabel1.Text, serhatlabel2.Text);
            }
            else
            {
                serhat1.color = Color.Green;
            }
        }





        //kısayol buton kodları
        private void button2_Click(object sender, EventArgs e)
        {
            MesajKisayol m = new MesajKisayol();
            m.İsimSoyisim.Text ="Ömer Şahin 10-C";
            m.ShowDialog();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MesajKisayol m = new MesajKisayol();
            m.İsimSoyisim.Text = "Oğuzhan Sapçili 10-C";
            m.ShowDialog();
        }

        private void SemihKisayol_Click(object sender, EventArgs e)
        {
            MesajKisayol m = new MesajKisayol();
            m.İsimSoyisim.Text = "Semih Tutkal 10-E";
            m.ShowDialog();
        }

        private void SerhatKisayol_Click(object sender, EventArgs e)
        {
            MesajKisayol m = new MesajKisayol();
            m.İsimSoyisim.Text = "Serhat Ay 10-A";
            m.ShowDialog();
        }
    }
}
