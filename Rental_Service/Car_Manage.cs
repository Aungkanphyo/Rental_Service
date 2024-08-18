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

namespace Rental_Service
{
    public partial class Car_Manage : Form
    {
        public Car_Manage()
        {
            InitializeComponent();
        }

        private void SaveBtn(object sender, EventArgs e)
        {
            ProjectConnetion pjConnect = new ProjectConnetion();
            // Ensure the connection is open
            pjConnect.OpenConnection();

            string query = "INSERT INTO excursion_car_rentaldb.testing (name) VALUES (@name)";
            MySqlCommand mySqlCommand = new MySqlCommand(query, pjConnect.mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@name",textBox1.Text);
        }
    }
}
