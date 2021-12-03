using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace Cat_Feeder
{
    public partial class FirstPage : Form, IFirstPageView
    {
        string login, password, status;
        public FirstPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Login: {login}\nPassword: {password}\nStatus: {status}");
        }
        //login
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //password
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            login = loginBox.Text;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.MaxLength = 8;
            PasswordBox.PasswordChar = '*';
            if (PasswordBox.Text.Length > 8)
            {
                MessageBox.Show("Длинна пароля должна быть 8 символов");
            }
            else if (PasswordBox.Text.Length == 8)
            {
                password = PasswordBox.Text;
            }
        }
        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                //устанавливаем статус Пользователь
                status = "User";
            }
        }
        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                //устанавливаем статус Админ
                status = "Admin";
            }
        }
    }
}
