using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sender_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                label_hiName.Text = "Привет!";
            }
            else
            {
                label_hiName.Text = $"Привет {name}!";
            }
        }

        int taps = 0;
        //int tap_power = 1; а ой сори
        int tapPower = 1;
        private void button_tap_Click_1(object sender, EventArgs e)
        {
            taps += tapPower;
            if (taps % 10 == 0)
            {
                tapPower++;
                label_power.Text = $"Потужность: {tapPower}";
            }
            label_clicks.Text = $"{taps} ПОТУЖНИХ КЛІКІВ!!!";
        }
    }
}
