using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            string input = txtBoxInput.Text.ToUpper();
            string[] pembagiKata = txtBoxInput.Text.Split(":");
            string[] pembagiKataString = input.Split(":");
            int jumlahTitikDua = input.Split(":").Length;
            if (jumlahTitikDua >= 2)
            {

                if (pembagiKataString[0] == "ISI")
                {
                    string outputPesan = "";
                    for (int i = 1; i < jumlahTitikDua; i++)
                    {
                        outputPesan += pembagiKata[i];
                    }
                    labelOutput.Text = outputPesan;
                }
                else if (pembagiKataString[0] == "WARNA")
                {
                    if (pembagiKataString[1] == " BIRU")
                    {
                        labelOutput.ForeColor = Color.Blue;
                    }
                    else if (pembagiKataString[1] == " DEFAULT")
                    {
                        labelOutput.ForeColor = Color.Black;
                    }
                    else if (pembagiKataString[1] == " MERAH")
                    {
                        labelOutput.ForeColor = Color.Red;
                    }
                    else if (pembagiKataString[1] == " HIJAU")
                    {
                        labelOutput.ForeColor = Color.Green;
                    }
                    else
                    {
                        string message = "Syntax tidak terdaftar!";
                        MessageBox.Show(message);
                    }
                }
                else
                {
                    string message = "Syntax tidak terdaftar!";
                    MessageBox.Show(message);
                }
            }
            else 
            {
                if (pembagiKataString[0] == "SHOWN")
                {
                    labelOutput.Show();
                }
                else if (pembagiKataString[0] == "HIDE")
                {
                    labelOutput.Hide();
                }
                else if (pembagiKataString[0] == "RESTART")
                {
                    labelOutput.Text = "[EMPTY]";
                    labelOutput.ForeColor = Color.Black;
                }
                else
                {
                    string message = "Syntax tidak terdaftar!";
                    MessageBox.Show(message);
                }
            }
        }

        private void txtBoxInput_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
