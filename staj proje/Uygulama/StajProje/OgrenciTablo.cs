using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class OgrenciTablo
    {
        public int OgrenciId { get; set; }
        public string OkulaGirisDonemi { get; set; }
        public string OgrenciNo { get; set; }
        public int OgrenciSinifi { get; set; }
        public int FakulteId { get; set; }
        public int BolumId { get; set; }
        public static bool OgrenciTabloEkle(OgrenciTablo yeniOgrenciTablo)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Ahmet_Ogrenci(OgrenciNo,OkulaGirisDonemi,OgrenciSinifi,FakulteId,BolumId) VALUES(@OgrenciNo,@OkulaGirisDonemi,@OgrenciSinifi,@FakulteId,@BolumId)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@OgrenciNo", yeniOgrenciTablo.OgrenciNo);
            cmd.Parameters.AddWithValue("@OkulaGirisDonemi", yeniOgrenciTablo.OkulaGirisDonemi);
            cmd.Parameters.AddWithValue("@OgrenciSinifi", yeniOgrenciTablo.OgrenciSinifi);
            cmd.Parameters.AddWithValue("@FakulteId", yeniOgrenciTablo.FakulteId);
            cmd.Parameters.AddWithValue("@BolumId", yeniOgrenciTablo.BolumId);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }
        
        public static int OgrenciIdBul(OgrenciTablo yeniOgrenci)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            
            conn.Open();
            cmd.CommandText = "SELECT OgrenciId FROM Ahmet_Ogrenci WHERE Ahmet_Ogrenci.OgrenciNo=@OgrenciNo";
            cmd.Parameters.AddWithValue("@OgrenciNo", yeniOgrenci.OgrenciNo);
            cmd.Connection = conn;
            
            int ogrenciid = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return ogrenciid;
        }
        
    }
}
