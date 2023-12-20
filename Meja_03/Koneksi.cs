using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meja_03
{
    internal class Koneksi
    {
        public SqlConnection GetCon()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=SAMS-PC\SQLSAMS; Initial Catalog=Meja_03; Integrated Security=True";
            return conn;
        }
    }
}
