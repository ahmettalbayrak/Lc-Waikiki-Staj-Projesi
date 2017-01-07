using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class NotlarTablo
    {
        public int NotlarId { get; set; }
        public int DerslerId { get; set; }
        public int OgrenciId { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
        public int Ortalama { get; set; }
        public static bool NotGiris(NotlarTablo yeniNotlarTablo)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Ahmet_Notlar(Vize,Final,Ortalama,DerslerId,OgrenciId) VALUES(@Vize,@Final,@Ortalama,@DerslerId,@OgrenciId)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Vize", yeniNotlarTablo.Vize);
            cmd.Parameters.AddWithValue("@Final", yeniNotlarTablo.Final);
            cmd.Parameters.AddWithValue("@Ortalama", yeniNotlarTablo.Ortalama);
            cmd.Parameters.AddWithValue("@DerslerId", yeniNotlarTablo.DerslerId);
            cmd.Parameters.AddWithValue("@OgrenciId", yeniNotlarTablo.OgrenciId);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }
    }
}
