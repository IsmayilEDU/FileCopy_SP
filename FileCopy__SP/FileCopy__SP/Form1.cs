using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopy__SP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Copy(string fileToCopy, string destinationDirectory)
        {
            destinationDirectory += "\\";
            File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy));
        }
        private void button_From_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                textBox_From.Text = choofdlog.FileName;
            }
        }


        private void button_To_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                textBox_To.Text = directchoosedlg.SelectedPath;
            }
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_From.Text == "") throw new Exception("Path of file can't be empty!");
                if (textBox_To.Text == "") throw new Exception("Path of folder can't be empty!");
                Copy(textBox_From.Text, textBox_To.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
