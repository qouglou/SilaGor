using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SilaGor
{
    public partial class RegisterSilaGor : Form
    {
        public RegisterSilaGor()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (surnameField.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (loginField.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (checkLogin())
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Вы успешно зарегистрировались");
            else
                MessageBox.Show("Произошла ошибка, попробуйте еще раз");
            db.closeConnection();
        }

        public Boolean checkLogin()
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLogin", db.getConnection());
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                return true;
            }
            else
                return false;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginSilaGor loginForm = new LoginSilaGor();
            loginForm.Show();
        }

        private void nameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ProcessTabKey(true);
            }
        }

        private void surnameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ProcessTabKey(true);
            }
        }

        private void loginField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ProcessTabKey(true);
            }
        }

        private void passField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonRegister_Click(this, EventArgs.Empty);
            }
        }

        private void RegisterSilaGor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
