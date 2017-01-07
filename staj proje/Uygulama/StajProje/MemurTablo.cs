using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class MemurTablo
    {
        public int MemurId { get; set; }
        public DateTime IseBaslama { get; set; }
        public string GecmisDeneyimler { get; set; }
        public static bool MemurTabloEkle(MemurTablo yeniMemurTablo)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Ahmet_Memur(IseBaslama,GecmisDeneyimler) VALUES(@IseBalama,@GecmisDeneyimler)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@IseBalama", yeniMemurTablo.IseBaslama);
            cmd.Parameters.AddWithValue("@GecmisDeneyimler", yeniMemurTablo.GecmisDeneyimler);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }
        public static int MemurIdBul()
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MAX(MemurId) FROM Ahmet_Memur";
            cmd.Connection = conn;
            conn.Open();
            int memurid = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return memurid;
        }
    }
    
}
