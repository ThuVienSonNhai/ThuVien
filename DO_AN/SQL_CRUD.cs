using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DO_AN
{
    internal class SQL_CRUD
    {
            string link_sql = @"Data Source=.\sqlexpress;Initial Catalog=QUANLYTHUVIEN;Integrated Security=True;TrustServerCertificate=True";

            public SqlConnection GetSqlConnection()
            {
                return new SqlConnection(link_sql);
            }
            public DataTable GetData(string select)
            {
                SqlConnection con = GetSqlConnection();
                SqlDataAdapter dap = new SqlDataAdapter(select, con);
                DataTable tab = new DataTable();
                dap.Fill(tab);
                return tab;
            }
    }
}
