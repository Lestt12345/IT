using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox1.Image = Image.FromFile("D:\\IT\\C#\\WindowsFormsApp2\\img\\asd.png");
                button1.Text = "неПотужно!";
                pictureBox2.Hide();
            }
            else if (radioButton4.Checked)
            {
                pictureBox1.Image = Image.FromFile("D:\\IT\\C#\\WindowsFormsApp2\\img\\dsa.png");
                button1.Text = "ПОТУЖНО!";
                pictureBox2.Hide();

            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            button1.Text = "Chek!";
            pictureBox2.Image = Image.FromFile("D:\\IT\\C#\\WindowsFormsApp2\\img\\Скриншот 11.01.25_16.50.52.png");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = "Chek!";
            pictureBox2.Image = Image.FromFile("D:\\IT\\C#\\WindowsFormsApp2\\img\\Скриншот 11.01.25_16.50.52.png");
        }
    }
}
