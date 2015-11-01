using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7.Data
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public static int ExecuteNonQuery(string commandText, SqlParameter[] paramsList)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand command = con.CreateCommand();
                command.CommandText = commandText;
                command.Parameters.AddRange(paramsList);

                int rowsEffected = command.ExecuteNonQuery();
                return rowsEffected;
            }
        }

        public static DataTable ExecuteReader(string commandText, SqlParameter[] paramsList)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand command = con.CreateCommand();
                command.CommandText = commandText;
                if (paramsList != null)
                    command.Parameters.AddRange(paramsList);

                SqlDataReader reader = command.ExecuteReader();
                
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
    }
}
