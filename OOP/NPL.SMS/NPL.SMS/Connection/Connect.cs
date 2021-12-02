using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NPL.SMS.Connection
{
    class Connect
    {
        private const string sqlStringConnection = "Data Source = DESKTOP-GP4GSIN ;Initial Catalog = SMS; Integrated Security = true";
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection connect = new SqlConnection(sqlStringConnection);
            return connect;
        }

        public static SqlCommand GetCommand(string query, SqlConnection connect)
        {
            SqlCommand cmd = new SqlCommand(query, connect);
            return cmd;
        }
    }
}
