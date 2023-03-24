using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilaGor
{
    public partial class RegisterDriver : Form
    {
        public RegisterDriver()
        {
            InitializeComponent();
        }

        private void buttonDriverRegister_Click(object sender, EventArgs e)
        {
            if (nameDriverField.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (surnameDriverField.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (loginDriverField.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passDriverField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (checkLogin())
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `drivers` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginDriverField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passDriverField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameDriverField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameDriverField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Поздравляем, вы зарегистрировались");
            else
                MessageBox.Show("Произошла ошибка, попробуйте еще раз");
            db.closeConnection();
        }

    public Boolean checkLogin()
    {
        string loginUser = loginDriverField.Text;
        string passUser = passDriverField.Text;

        DataBase db = new DataBase();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        MySqlCommand command = new MySqlCommand("SELECT * FROM `drivers` WHERE `login` = @driverLogin", db.getConnection());
        command.Parameters.Add("@driverLogin", MySqlDbType.VarChar).Value = loginDriverField.Text;

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

        private void registerDriverLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDriver registerForm = new LoginDriver();
            registerForm.Show();
        }

        private void nameDriverField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ProcessTabKey(true);
            }
        }

        private void surnameDriverField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ProcessTabKey(true);
            }
        }

        private void loginDriverField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ProcessTabKey(true);
            }
        }

        private void passDriverField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonDriverRegister_Click(this, EventArgs.Empty);
            }
        }

        private void RegisterDriver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
