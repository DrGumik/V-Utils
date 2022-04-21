/// <summary>
/// 
/// Created by Jakub Tenk
/// 
/// Simple program V-Utils for DIY vaping in CZ lang.
///  - Ohm meter calculator (include power, current consumation and battery test calculation)
///  - Nicotine calculator
///  - Base ratio
///  
/// </summary>

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vape_ohm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OhmMeter_Click(object sender, EventArgs e)
        {
            if (tb_BatteryMaxCurrent.Text.ToString() == "" || tb_Ohm.Text.ToString() == "")
            {
                MessageBox.Show("Vložte parametry baterie a odpor spirálky");
                return;
            }

            double maxCurrent = double.Parse(tb_BatteryMaxCurrent.Text.ToString());
            double ohm = double.Parse(tb_Ohm.Text.ToString());
            double voltage = 3.2 + 0.1 * tb_BatteryVoltage.Value;
            double current, power;
            
            current = voltage / ohm;
            power = voltage * current;
            tb_BatteryOutCurrent.Text = current.ToString("0.000");
            tb_Power.Text = power.ToString("0.000");

            if (maxCurrent > current)
            {
                lbl_BatteryTest.ForeColor = Color.ForestGreen;
                lbl_BatteryTest.Text = "Kontrola baterie: Baterie je dostatečná!";
            }
            if (maxCurrent < current)
            {
                lbl_BatteryTest.ForeColor = Color.Red;
                lbl_BatteryTest.Text = "Kontrola baterie: Baterie je nedostatečná!";
            }
            if (maxCurrent == current)
            {
                lbl_BatteryTest.ForeColor = Color.Orange;
                lbl_BatteryTest.Text = "Kontrola baterie: Baterie je dostatečná, ale s omezením!";
            }
        }

        private void tbOhm_KeyBlock(object sender, KeyPressEventArgs e)
        {
            if ("." == e.KeyChar.ToString())
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void tbA_KeyBlock(object sender, KeyPressEventArgs e)
        {
            if ("." == e.KeyChar.ToString())
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void btn_NicotineCalculator_Click(object sender, EventArgs e)
        {
            if (tbONB.Text.ToString() == "" || tbPON.Text.ToString() == "" || tbMMB.Text.ToString() == "")
            {
                MessageBox.Show("Vložte parametry do nikotinové kalkulačky");
                return;
            }

            double nikotinbooster = double.Parse(tbONB.Text.ToString());
            double nikotin = double.Parse(tbPON.Text.ToString());
            double juicebase = double.Parse(tbMMB.Text.ToString());
            double a;

            a = juicebase / (nikotinbooster / nikotin);

            tbPMB.Text = a.ToString("0.0") + " ml";
            tbPMBB.Text = (juicebase-a).ToString("0.0") + " ml";

        }

        private void btn_BaseCalculator_Click(object sender, EventArgs e)
        {
            if (tbVG.Text.ToString() == "" || tbPG.Text.ToString() == "")
            {
                MessageBox.Show("Vložte parametry báze");
                return;
            }

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
