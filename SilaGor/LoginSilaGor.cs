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
    public partial class LoginSilaGor : Form
    {
        public LoginSilaGor()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLogin AND `pass` = @userPass", db.getConnection());
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainSilaGor mainForm = new MainSilaGor();
                SilaGor.MainSilaGor.UserLogin = loginField.Text;
                SilaGor.StatusOrder.UserLogin = loginField.Text;
                mainForm.Show();
            }
            else
                MessageBox.Show("Пользователя с таким логином или паролем не существует");
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterSilaGor registerForm = new RegisterSilaGor();
            registerForm.Show();
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
                buttonLogin_Click(this, EventArgs.Empty);
            }
        }

        private void logToDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDriver registerForm = new LoginDriver();
            registerForm.Show();
        }
    }
}
