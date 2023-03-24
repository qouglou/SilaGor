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
    public partial class ActiveOrder : Form
    {
        public static string ClientName;
        public static string AddressHome;
        public static string AddressDestination;


        public ActiveOrder()
        {
            InitializeComponent();
        }
        private void ActiveOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ActiveOrder_Shown(object sender, EventArgs e)
        {
            nameClient.Text = ClientName;
            adressHomeField.Text = AddressHome;
            addressDestinationField.Text = AddressDestination;
        }
    }
}
