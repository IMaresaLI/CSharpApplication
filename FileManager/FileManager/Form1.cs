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

namespace FileManager
{
    public partial class Form1 : Form
    {
        FileManager FileManager = new FileManager();

        public Form1()
        {
            InitializeComponent();
            GetAllDrivers();
            CountFileTbx.ForeColor = Color.LightSlateGray;
            CountFileTbx.BackColor = Color.White;
        }


        public void GetAllDrivers()
        {
            string[] drivers = Directory.GetLogicalDrives();
            for (int i = 0; i < drivers.Length; i++)
            {
                fileCbx.Items.Add(drivers[i]);
            }
            fileCbx.Text = drivers[0];
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in FileManager.GetAllDirectory(fileCbx.SelectedItem.ToString(),TextTbx.Text,uzantıCbx.SelectedItem.ToString()))
            {
                listBox1.Items.Add(item);
            }
            CountFileTbx.Text = listBox1.Items.Count.ToString();

        }

        private void TextTbx_MouseClick(object sender, MouseEventArgs e)
        {
            TextTbx.Text = "";
            TextTbx.ForeColor = Color.Black;
        }

        private void TextTbx_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TextTbx.Text))
            {
                TextTbx.Text = "Search";
                TextTbx.ForeColor = Color.LightSlateGray;
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string file = listBox1.SelectedItem.ToString();
            FileInfo f1 = new FileInfo(file);
            string fileLength = ((double)f1.Length / 1024 / 1024).ToString("0.####");
            FileInfoTbx.Text = "File Name : " + f1.Name + "\r\n" + "Creation Time : " + f1.CreationTime + "\r\n" + "Last Update Time : " + f1.LastWriteTime + "\r\n" + "File size : " + fileLength + " MB";
        }
    }
}
