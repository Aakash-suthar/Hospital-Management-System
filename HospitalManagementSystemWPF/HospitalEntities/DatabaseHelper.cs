using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This is a user defined class that helps in getting the connection object(s) throughout the program
/// </summary>
namespace HospitalEntities
{
    public class DatabaseHelper
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AkashMain;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connectionString);
        private static SqlCommand command = new SqlCommand();

        public static SqlConnection GetConnectionObject()
        {
            return conn;
        }
        public static SqlCommand GetCommandObject()
        {
            command.Connection = conn;
            return command;
        }
    }
}
