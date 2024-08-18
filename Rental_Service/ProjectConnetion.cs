using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rental_Service
{
    public partial class ProjectConnetion : Form
    {
        public MySqlConnection mySqlConnection {  get; set; }  
        public ProjectConnetion()
        {
            InitializeComponent();
            string mysqlConn = "server=127.0.0.1; user=root; database=excursion_car_rentaldb; password=";
            mySqlConnection = new MySqlConnection(mysqlConn);
        }

        public void OpenConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Closed) { 
                mySqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
        }
    }
}
