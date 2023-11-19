using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yarıçapı_girilen_dairenin_alanı_va_cevresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            double yaricap = Convert.ToDouble(txtYaricap.Text);
            double alan = Math.PI * yaricap * yaricap;
            double cevre = 2 * Math.PI * yaricap;
            lblAlan.Text = ("alanınız:" + alan.ToString());
            lblCevre.Text = ("çevreniz:" + cevre.ToString());

        }
    }
}
