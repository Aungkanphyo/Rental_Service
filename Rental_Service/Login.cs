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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // Connection Obj Call
        Connection con = new Connection();
       
        private void loginBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con.connectionString);

            try
            {

                
                conn.Open();

                MessageBox.Show("Success Connection");

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
