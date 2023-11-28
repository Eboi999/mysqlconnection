using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MySql.Data.MySqlClient;

namespace mysqlconnection.myclass
{
    internal class connection_class
    {
        public MySqlConnection connectdb;

        public connection_class()
        {
            string host = "localhost";
            string database = "studentdb";
            string username = "root";
            string password = "";
            string port = "3306";


            string connection_string = "datasource =" + host + ";database=" + database + "; port=" + port + "; username=" + username + ";" +"password=" + password + "; SslMode =none;";



            connectdb = new MySqlConnection(connection_string);
        }


    }
}
