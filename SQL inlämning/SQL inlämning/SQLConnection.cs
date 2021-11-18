using System.Data;
using System.Data.SqlClient;

namespace SQL_inlämning
{
    internal class SQLConnection
    {
        public static DataTable SqlConnection(string sqlCommand)
        {
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=Inlämning1;Trusted_Connection=True;";

            var sqlQuery = "Select Top 10 * from People";
            SqlConnection con = null;
            SqlCommand cmd = null;
            DataTable dta = null;
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sqlQuery, con);
            var adapter = new SqlDataAdapter(cmd);

            dta = new DataTable();
            adapter.Fill(dta);

            if (dta.Rows.Count > 0)
            {
                foreach (DataRow person in dta.Rows)
                {
                    Console.WriteLine(person[0] + " " + person[1]);
                }
            }
            con.Open();
            return dta;
        }
    }
}

