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
using System.Diagnostics;
using System.Security.Cryptography;

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

        public void Encrypt(string inputFile, string outputFile)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                FileStream fstreamIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                FileStream fstreamOut = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
                byte[] buf = new byte[64];
                for (; ; )
                {
                    int bytesRead = fstreamIn.Read(buf, 0, buf.Length);
                    if (bytesRead == 0) break;
                    byte[] encrypted = bytesRead == buf.Length ? rsa.Encrypt(buf, true) : rsa.Encrypt(buf.Take(bytesRead).ToArray(), true);
                    fstreamOut.Write(encrypted, 0, encrypted.Length);
                }
            }

        }

        void Decrypt(string inputFile, string outputFile)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                //rsa.ImportParameters(rsaPrivateKey);

                FileStream fstreamIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                FileStream fstreamOut = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
                {
                    byte[] buf = new byte[128];
                    for (; ; )
                    {
                        int bytesRead = fstreamIn.Read(buf, 0, buf.Length);
                        if (bytesRead == 0) break;
                        byte[] decrypted = rsa.Decrypt(buf, true);
                        fstreamOut.Write(decrypted, 0, decrypted.Length);
                    }
                }
            }
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {

            Encrypt(openFileDialog1.FileName, openFileDialog1.FileName + ".crypt");
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
                temp = teDecrypt(temp);
                newFile.WriteByte(Convert.ToByte(temp));
            }
            localFile.Close();
            newFile.Close();
            MessageBox.Show("OK");
        }






    }
}
