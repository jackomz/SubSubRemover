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

namespace SubSubRemover
{
    public partial class Form1 : Form
    {

        private string openFileName, folderName;

        private bool fileOpened = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.Width < 500) { this.Width = 500; }

            this.textBox1.Width = this.Width - 40;
            this.button1.Width = this.Width - 40;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
