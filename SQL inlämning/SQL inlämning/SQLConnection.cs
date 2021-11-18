using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_inlämning
{
    internal class SQLConnection
    {
        public static DataTable GetDataTable(string sql, string paramName, string paramValue)
        {
            var connectionString = "server=(localdb)\\mssqllocaldb;integrated security=true;database=People";
            var dt = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue(paramName, paramValue);
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
