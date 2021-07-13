using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardPasswordCreatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string generatorPw(int LengthCharacter)
        {
            string valid = "";

            if (LetterRbtn.Checked)
            {
                valid = "";
                valid += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXY";
            }
            else if (NumberRBtn.Checked)
            {
                valid = "";
                valid += "0123456789";
            }
            else if (BothRBtn.Checked)
            {
                valid = "";
                valid += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXY0123456789";
            }

            if (SpecialCbx.Checked)
            {
                valid += "/*-+][\\=";
            }

            string pw = "";
            Random rnd = new Random();
            while (0 < LengthCharacter--)
            {
                pw += valid[rnd.Next(valid.Length)];
            }
                
            return pw;
        }

        private void CreatePwBtn_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]*$");
            if (String.IsNullOrEmpty(ChLenghtTbx.Text) == false && reg.IsMatch(ChLenghtTbx.Text))
            {
                int length = Convert.ToInt32(ChLenghtTbx.Text);
                PwTbx.Text = generatorPw(LengthCharacter: length);
                PwTbx.BackColor = Color.White;
                PwTbx.ForeColor = Color.RoyalBlue;

            }else
            {
                MessageBox.Show("No valid length value was entered.");
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PwTbx.Text) == false)
            {
                Clipboard.SetText(PwTbx.Text);
            }
        }
    }
}
