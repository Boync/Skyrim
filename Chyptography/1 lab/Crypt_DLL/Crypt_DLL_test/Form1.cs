using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypt_DLL_library;
using System.Numerics;

namespace Crypt_DLL_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_powermod_Click(object sender, EventArgs e)
        {
            BigInteger bas = BigInteger.Parse(textBox_base.Text);
            BigInteger exponent = BigInteger.Parse(textBox_exponent.Text);
            BigInteger modulus = BigInteger.Parse(textBox_modulus.Text);
            textBox_powermod.Text = BigInteger.ModPow(bas, exponent, modulus).ToString();
            
        }

        private void button_evklid_Click(object sender, EventArgs e)
        {
            BigInteger a = Convert.ToInt64(textBox_a.Text);
            BigInteger b = Convert.ToInt64(textBox_b.Text);
            BigInteger xr = 1;
            BigInteger yr = 1;
            BigInteger dr = 1;
            Crypt.evklid(a, b, ref xr, ref yr, ref dr);
            textBox_x.Text = xr.ToString();
            textBox_y.Text = yr.ToString();
            textBox_gcd.Text = dr.ToString();
        }

        private void button_df_Click(object sender, EventArgs e)
        {
            BigInteger rp = BigInteger.Parse(textBox_p.Text);
            BigInteger ra = BigInteger.Parse(textBox_a2.Text);
            BigInteger rx1 = BigInteger.Parse(textBox_x1.Text);
            BigInteger rx2 = BigInteger.Parse(textBox_x2.Text);
            BigInteger rz1 = 1;
            BigInteger rz2 = 1;
            Crypt.diffi_hellman(rp, ra, rx1, rx2, ref rz1, ref rz2);
            textBox_z1.Text = rz1.ToString();
            textBox_z2.Text = rz2.ToString();
        }

    }
}
