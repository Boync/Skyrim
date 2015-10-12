using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Title = "Open file...";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {

                textBox_filepath.Text = openFileDialog1.FileName;
                textBox1.Text = Convert.ToString(openFileDialog1.FileName.Length);
            
            }

        }

        public byte testEncrypt(byte sByte)
        {

            sByte = (byte)(sByte * 2);
            return sByte;

        }

        public byte testDecrypt(byte sByte)
        {

            sByte = (byte)(sByte / 2);
            return sByte;

        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {

            byte temp;
            FileStream localFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            FileStream newFile = new FileStream(openFileDialog1.FileName + ".crypt", FileMode.Create);
            for (long i = 0; i < localFile.Length; i++)
            {
                temp = Convert.ToByte(localFile.ReadByte());
                textBox2.Text = textBox2.Text + Convert.ToString(temp);
                temp = testEncrypt(temp);
                textBox3.Text = textBox3.Text + Convert.ToString(temp);
                newFile.WriteByte(Convert.ToByte(temp));
            }
            localFile.Close();
            newFile.Close();
            MessageBox.Show("OK");
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {

            byte temp;
            FileStream localFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            FileStream newFile = new FileStream("test.jpg", FileMode.Create);
            for (long i = 0; i < localFile.Length; i++)
            {
                temp = Convert.ToByte(localFile.ReadByte());
                temp = testDecrypt(temp);
                newFile.WriteByte(Convert.ToByte(temp));
            }
            localFile.Close();
            newFile.Close();
            MessageBox.Show("OK");
        }






    }
}
