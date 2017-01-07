using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StajProje
{
    class DbConncection
    {
        public static SqlConnection GetSqlConnection()
        {
            var conn = new SqlConnection();
            conn.ConnectionString = "Server=.; Database=StajyerTestDB; Trusted_Connection=SSPI";
            return conn;
        }
    }
}
