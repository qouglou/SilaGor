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
    public partial class MainSilaGor : Form
    {
        public static string UserLogin;
        public MainSilaGor()
        {
            InitializeComponent();
        }

        private void MainSilaGor_Load(object sender, EventArgs e)
        {
            var db = new DataBase();
            string command = "SELECT name FROM users WHERE login = '" + UserLogin + "'";
            MySqlCommand sqlCommand = new MySqlCommand(command, db.getConnection());
            db.openConnection();
            string name = sqlCommand.ExecuteScalar().ToString();
            loginSelect.Text = name;
            db.closeConnection();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (adressHomeField.Text != "")
            {
                var db = new DataBase();
                string command = "UPDATE users SET addressHome = '" + adressHomeField.Text + "', addressDestination = '" + addressDestinationField.Text + "', status = 'active' WHERE login = '" + UserLogin + "'";
                string cmd = "INSERT INTO orders (addressHome, addressDestination, login) VALUES ('" + adressHomeField.Text + "', '" + addressDestinationField.Text + "', '" + UserLogin + "')";
                MySqlCommand sqlcmn = new MySqlCommand(command, db.getConnection());
                MySqlCommand sqlcmnd = new MySqlCommand(cmd, db.getConnection());
                db.openConnection();
                sqlcmnd.ExecuteNonQuery();
                if (sqlcmn.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вы успешно заказали такси с " + adressHomeField.Text + " на " + addressDestinationField.Text + " ");
                    this.Hide();
                    StatusOrder mainForm = new StatusOrder();
                    mainForm.Show();
                }
                db.closeConnection();
            }
        }

        private void MainSilaGor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void adressHomeField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ProcessTabKey(true);
            }
        }

        private void addressDestinationField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonSelect_Click(this, EventArgs.Empty);
            }
        }
    }
}
