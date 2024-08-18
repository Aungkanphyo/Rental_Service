using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Service
{

    internal class connection
    {
        public string connectionString;
        public MySqlConnection mySqlConn;

        // Constructor
        public connection()
        {
            connectionString = "server=127.0.0.1;user=root;database=cshark;password= ";
            
        }
    }
}
