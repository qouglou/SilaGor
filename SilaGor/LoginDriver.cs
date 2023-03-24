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
    public partial class LoginDriver : Form
    {
        public LoginDriver()
        {
            InitializeComponent();
        }

        private void buttonDriverLogin_Click(object sender, EventArgs e)
        {
            string loginDriver = driverLoginField.Text;
            string passDriver = driverPassField.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandDriver = new MySqlCommand("SELECT * FROM `drivers` WHERE `login` = @driverLogin AND `pass` = @driverPass", db.getConnection());
            commandDriver.Parameters.Add("@driverLogin", MySqlDbType.VarChar).Value = loginDriver;
            commandDriver.Parameters.Add("@driverPass", MySqlDbType.VarChar).Value = passDriver;

            adapter.SelectCommand = commandDriver;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainDriver mainForm = new MainDriver();
                SilaGor.MainDriver.DriverLogin = driverLoginField.Text;
                mainForm.Show();
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        private void registerDriverLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterDriver registerForm = new RegisterDriver();
            registerForm.Show();
        }

        private void driverLoginField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ProcessTabKey(true);
            }
        }

        private void driverPassField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonDriverLogin_Click(this, EventArgs.Empty);
            }
        }

        private void TaxiLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
