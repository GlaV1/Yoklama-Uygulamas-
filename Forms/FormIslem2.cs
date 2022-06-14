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
    public partial class FormIslem2 : Form
    {
        public FormIslem2()
        {
            InitializeComponent();
          
        }
        private void FormIslem2_Load(object sender, EventArgs e)
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
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
