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

       // RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
       // rsaPrivateKey = rsa.ExportParameters(true);//экспорт закрытого ключа
       // rsaOpenKey = rsa.ExportParameters(false);//экспорт открытого ключа

        private void button_view_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Title = "Open file...";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {

                textBox_filepath.Text = openFileDialog1.FileName;
                //textBox1.Text = Convert.ToString(openFileDialog1.FileName.Length);
            
            }

        }

        public void Encrypt(string inputFile, string outputFile)
        {
            long temp = 0;
            FileStream streamIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            FileStream streamOut = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
            BinaryReader binIn = new BinaryReader(streamIn);
            BinaryWriter binOut = new BinaryWriter(streamOut);
            for (long i = 1; i <= streamIn.Length / 8; i++)
            {

                temp = binIn.ReadInt64();
                temp = temp * 2;
                binOut.Write(temp);
            }

            binIn.Close();
            binOut.Close();
            streamIn.Close();
            streamOut.Close();
            
        }

        public void Decrypt(string inputFile, string outputFile)
        {

            long temp = 0;
            FileStream streamIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            FileStream streamOut = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
            BinaryReader binIn = new BinaryReader(streamIn);
            BinaryWriter binOut = new BinaryWriter(streamOut);
            for (long i = 1; i <= streamIn.Length / 8; i++)
            {

                temp = binIn.ReadInt64();
                temp = temp / 2;
                binOut.Write(temp);
            }

            binIn.Close();
            binOut.Close();
            streamIn.Close();
            streamOut.Close();
            

            
        }


        private void button_run_Click(object sender, EventArgs e)
        {

           if (comboBox_crypt.SelectedItem == "Encrypt") Encrypt(openFileDialog1.FileName, openFileDialog1.FileName + ".crypt");
           else if (comboBox_crypt.SelectedItem == "Decrypt") Decrypt(openFileDialog1.FileName, openFileDialog1.FileName.Remove(openFileDialog1.FileName.Length - 6) + "(1)");
            MessageBox.Show("OK");
        }


    }
}
