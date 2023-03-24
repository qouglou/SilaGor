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
    public partial class StatusOrder : Form
    {
        public static string UserLogin;
        public StatusOrder()
        {
            InitializeComponent();
        }

        private void StatusOrder_Load(object sender, EventArgs e)
        {
            var db = new DataBase();
            string command = "SELECT name FROM users WHERE login = '" + UserLogin + "'";
            MySqlCommand sqlCommand = new MySqlCommand(command, db.getConnection());
            db.openConnection();
            string name = sqlCommand.ExecuteScalar().ToString();
            loginSelect.Text = name;
            db.closeConnection();
        }

        private void buttonEndOrder_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            string command = "UPDATE users SET status = 'inactive' WHERE login = '" + UserLogin + "'";
            MySqlCommand sqlcmn = new MySqlCommand(command, db.getConnection());
            db.openConnection();
            if (sqlcmn.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно завершили заказ");
            }
            db.closeConnection();
            Application.Exit();
        }

        private void StatusOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            var db = new DataBase();
            string command = "UPDATE users SET status = 'inactive' WHERE login = '" + UserLogin + "'";
            MySqlCommand sqlcmn = new MySqlCommand(command, db.getConnection());
            db.openConnection();
            sqlcmn.ExecuteNonQuery();
            db.closeConnection();
            Application.Exit();
        }
    }
}
