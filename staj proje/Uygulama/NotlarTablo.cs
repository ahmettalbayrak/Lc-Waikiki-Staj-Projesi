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

        public static int NotGirisi(NotlarTablo yeniNotlarTablo)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO Ahmet_Notlar(Vize,DerslerId,OgrenciId) VALUES(@Vize,@DerslerId,@OgrenciId)";
            cmd.Parameters.AddWithValue("@Vize", yeniNotlarTablo.Vize);
            cmd.Parameters.AddWithValue("@DerslerId", yeniNotlarTablo.DerslerId);
            cmd.Parameters.AddWithValue("@OgrenciId", yeniNotlarTablo.OgrenciId);
            int kaydedildiMi = cmd.ExecuteNonQuery();
            conn.Close();
            return kaydedildiMi;

        }

        public static int NotFinalOrtalama(NotlarTablo yeniNotlarTablo)
        {


            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Ahmet_Notlar SET Final=@Final,Ortalama=@Ortalama WHERE Ahmet_Notlar.OgrenciId=@OgrenciId AND Ahmet_Notlar.DerslerId=@DerslerId";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Final", yeniNotlarTablo.Final);
            cmd.Parameters.AddWithValue("@Ortalama", yeniNotlarTablo.Ortalama);
            cmd.Parameters.AddWithValue("@OgrenciId", yeniNotlarTablo.OgrenciId);
            cmd.Parameters.AddWithValue("@DerslerId", yeniNotlarTablo.DerslerId);
            conn.Open();
            int kaydedildiMi = cmd.ExecuteNonQuery();
            conn.Close();
            return kaydedildiMi;
        }




        //public static bool NotSil(NotlarTablo yeninotid)
        //{
        //    SqlConnection conn = DbConncection.GetSqlConnection();
        //    var cmd = new SqlCommand();
        //    cmd.Connection = conn;
        //    conn.Open();
        //    cmd.CommandText = "DELETE FROM Ahmet_Notlar WHERE Ahmet_Notlar.OgrenciId=@OgrenciId and Ahmet_Notlar.DerslerId=@DerslerId   ";
        //    cmd.Parameters.AddWithValue("@OgrenciId", yeninotid.OgrenciId);
        //    cmd.Parameters.AddWithValue("@DerslerId", yeninotid.DerslerId);
        //    conn.Close();

        //    return cmd.ExecuteNonQuery() > 0;

        //}
    }
}


