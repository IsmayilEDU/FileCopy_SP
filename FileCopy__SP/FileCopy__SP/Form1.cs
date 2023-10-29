using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopy__SP
{
    public partial class Form1 : Form
    {
        Thread thread;
        bool IsSuspend;
        public Form1()
        {
            InitializeComponent();
            IsSuspend = false;
        }
        private void Copy()
        {
            var FileCopier = new CustomFileCopier(textBox_From.Text, textBox_To.Text, ref progressBar_FileStream);
            FileCopier.Copy();
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_From.Text == "") throw new Exception("Path of file can't be empty!");
                if (textBox_To.Text == "") throw new Exception("Path of folder can't be empty!");
                thread = new Thread(Copy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Click functions of thread buttons
        private void button_Suspend_Click(object sender, EventArgs e)
        {
            thread.Suspend();
            IsSuspend= true;
        }

        private void button_Resume_Click(object sender, EventArgs e)
        {
            if (IsSuspend)
            {
                thread.Resume();
            }
        }

        private void button_Abort_Click(object sender, EventArgs e)
        {
            thread.Abort();
        }

        #endregion

        #region Click functions (from and to path)
        private void button_From_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Text|*.txt";
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                textBox_From.Text = choofdlog.FileName;
            }
        }
        private void button_To_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Text|*.txt";
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                textBox_To.Text = choofdlog.FileName;
            }
        }

        #endregion

    }

}
