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
    public partial class MainDriver : Form
    {
        public static string DriverLogin;
        public MainDriver()
        {
            InitializeComponent();
        }

        private void MainDriver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainDriver_Shown(object sender, EventArgs e)
        {
            var db = new DataBase();
            string command = "SELECT name FROM drivers WHERE login = '" + DriverLogin + "'";
            MySqlCommand sqlCommand = new MySqlCommand(command, db.getConnection());
            db.openConnection();
            string name = sqlCommand.ExecuteScalar().ToString();
            loginDriverSelect.Text = name;
            fillGrid(db);
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            if (List.SelectedRows[0].Cells[0].Value != null)
            {
                string name = List.SelectedRows[0].Cells[0].Value.ToString();
                string comand = "SELECT status FROM users WHERE name='" + name + "'";
                var sqlCommand = new MySqlCommand(comand, db.getConnection());
                db.openConnection();
                var status = sqlCommand.ExecuteScalar().ToString();
                if (status == "active")
                {
                    comand = "UPDATE users SET status = 'inactive' WHERE name ='" + name + "'";
                    sqlCommand = new MySqlCommand(comand, db.getConnection());
                    sqlCommand.ExecuteNonQuery();
                    List.Rows.Remove(List.SelectedRows[0]);
                    MessageBox.Show("Вы выбрали заказ");
                    this.Hide();
                    SilaGor.ActiveOrder.ClientName = List.SelectedRows[0].Cells[0].Value.ToString();
                    SilaGor.ActiveOrder.AddressHome = List.SelectedRows[0].Cells[1].Value.ToString();
                    SilaGor.ActiveOrder.AddressDestination = List.SelectedRows[0].Cells[2].Value.ToString();
                    ActiveOrder loginForm = new ActiveOrder();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Данный клиент уже занят");
                    List.Rows.Remove(List.SelectedRows[0]);
                }
                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Выберите заказ!!");
            }
        }

        private void fillGrid(DataBase db)
        {
            string command = "SELECT name, addressHome, addressDestination FROM users WHERE status='active'";
            var sqlCommand = new MySqlCommand(command, db.getConnection());
            var reader = sqlCommand.ExecuteReader();
            int row = 0;
            while (reader.Read())
            {
                if (List.Rows.Count < row + 2)
                    List.Rows.Add();
                for (int column = 0; column < 3; column++)
                {
                    List.Rows[row].Cells[column].Value = reader[column].ToString();
                }
                row++;
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List.Rows.Clear();
            var db = new DataBase();
            db.openConnection();
            fillGrid(db);
            db.closeConnection();
        }
    }
}
