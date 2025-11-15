using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.SizeChanged += MainForm_SizeChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            panel1.Location = new Point(
                (this.ClientSize.Width - panel1.Width) / 2,
                (this.ClientSize.Height - panel1.Height) / 2
            );
        }
        //ну не мое окей :)

        struct users_data
        {
            public string login;
            public string password;
        }
        users_data[] users = new users_data[] {
            new users_data { login = "user1", password = "pass1"},
            new users_data { login = "user2", password = "pass2"},
            new users_data { login = "user3", password = "pass3"}
        };

        private void label_forgetPass_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;

            foreach (users_data user in users)
            {
                if (user.login == login)
                {
                    MessageBox.Show(user.password);
                    return;
                }
            }

            MessageBox.Show("Неверный логин");
            return;
        }

        private void button_signIn_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                label_error.Text = "Не все поля зополнены";
                label_error.ForeColor = Color.Red;
                return;
            }

            foreach (users_data user in users)
            {
                if (user.login == login && user.password == password)
                {
                    textBox_login.Clear();
                    textBox_password.Clear();
                    label_error.Text = "Успешно";
                    label_error.ForeColor = Color.DarkGreen;
                    return;
                }
            }

            label_error.Text = "Неверные данные";
            label_error.ForeColor = Color.Red;
            return;
        }
    }
}
