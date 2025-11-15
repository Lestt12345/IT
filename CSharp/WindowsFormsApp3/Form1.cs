using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string username = textBox_login.Text;
            string pasword = textBox_pasword.Text;
            string condirm_pasword = textBox_paswordAgain.Text;
            string email = textBox_email.Text;
            bool rules = checkBox_rules.Checked;

            if (pasword != condirm_pasword)
            {
                label_error.Text = "Пароли не совпадают";
                label_error.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(pasword) ||
                string.IsNullOrEmpty(condirm_pasword) ||
                string.IsNullOrEmpty(email))
            {
                label_error.Text = "Не все поля зополнены";
                label_error.ForeColor = Color.Red;
                return;
            }

            if (!rules)
            {
                label_error.Text = "Вы должни принять наши условия";
                label_error.ForeColor = Color.Red;
                return;
            }

            textBox_login.Clear();
            textBox_pasword.Clear();
            textBox_paswordAgain.Clear();
            textBox_email.Clear();
            textBox_code.Clear();
            checkBox_rules.Checked = false;
            label_error.Text = "Успешно";
            label_error.ForeColor = Color.DarkGreen;
            return;
        }
    }
}
