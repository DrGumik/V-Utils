using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vape_ohm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int voltsw = tb1.Value;

            double volt = 3.2;
            double amp = double.Parse(tbA.Text.ToString());
            double ohm = double.Parse(tbO.Text.ToString());
            double AB, W;

            switch (voltsw)
            {
                case 0:
                    volt = 3.2;
                    break;
                case 1:
                    volt = 3.3;
                    break;
                case 2:
                    volt = 3.4;
                    break;
                case 3:
                    volt = 3.5;
                    break;
                case 4:
                    volt = 3.6;
                    break;
                case 5:
                    volt = 3.7;
                    break;
                case 6:
                    volt = 3.8;
                    break;
                case 7:
                    volt = 3.9;
                    break;
                case 8:
                    volt = 4.0;
                    break;
                case 9:
                    volt = 4.1;
                    break;
                case 10:
                    volt = 4.2;
                    break;
            }

            AB = volt / ohm;
            W = volt * AB;
            tbAB.Text = AB.ToString("0.000");
            tbW.Text = W.ToString("0.000");
            if (amp > AB)
            {
                lbl9.ForeColor = Color.ForestGreen;
                lbl9.Text = "Kontrola baterie: Baterie je dostatečná!";
            }
            if (amp < AB)
            {
                lbl9.ForeColor = Color.Red;
                lbl9.Text = "Kontrola baterie: Baterie je nedostatečná!";
            }
            if (amp == AB)
            {
                lbl9.ForeColor = Color.Orange;
                lbl9.Text = "Kontrola baterie: Baterie je dostatečná, ale s omezením!";
            }
        }

        private void tbOhm_KeyBlock(object sender, KeyPressEventArgs e)
        {
            string test = e.KeyChar.ToString();
            if ("." == test)
            {
                //MessageBox.Show("Znak tečka je zakázán. Použij čárku!");
                e.Handled = true;
            }
            else 
            {
                e.Handled = false;
            }
        }

        private void tbA_KeyBlock(object sender, KeyPressEventArgs e)
        {
            string test = e.KeyChar.ToString();
            if ("." == test)
            {
                //MessageBox.Show("Znak tečka je zakázán. Použij čárku!");
                e.Handled = true;                
            }
            else
            {
                e.Handled = false;
            }            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double nikotinbooster = double.Parse(tbONB.Text.ToString());
            double nikotin = double.Parse(tbPON.Text.ToString());
            double juicebase = double.Parse(tbMMB.Text.ToString());
            double a;

            a = juicebase / (nikotinbooster / nikotin);

            tbPMB.Text = a.ToString("0.0") + " ml";
            tbPMBB.Text = (juicebase-a).ToString("0.0") + " ml";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double vg = double.Parse(tbVG.Text.ToString());
            double pg = double.Parse(tbPG.Text.ToString());
            double a,b,c;

            a = vg + pg;
            b = vg / a * 100;
            c = pg / a * 100;
            tbOCB.Text = a.ToString("0.0") + " ml";
            tbPOMER.Text = b.ToString("0.0") + " / " + c.ToString("0.0");
        }
    }
}
