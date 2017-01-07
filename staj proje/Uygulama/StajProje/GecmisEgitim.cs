using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class GecmisEgitim
    {
        public int GecmisId { get; set; }
        public int MezuniyetYil { get; set; }
        public double MezuniyetDerecesi { get; set; }
        public string MezunOkul { get; set; }
        public int OgrenciId { get; set; }
        public int OgretmenId { get; set; }
        public int MemurId { get; set; }
        public static bool GecmisOgrenciEkle(GecmisEgitim yeniOgrenciGecmis)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Ahmet_GecmisEgitim(MezuniyetYil,MezuniyetDerecesi,MezunOkul,OgrenciId) VALUES(@MezuniyetYil,@MezuniyetDerecesi,@MezunOkul,@OgrenciId)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@MezuniyetYil", yeniOgrenciGecmis.MezuniyetYil);
            cmd.Parameters.AddWithValue("@MezuniyetDerecesi", yeniOgrenciGecmis.MezuniyetDerecesi);
            cmd.Parameters.AddWithValue("@MezunOkul", yeniOgrenciGecmis.MezunOkul);
            cmd.Parameters.AddWithValue("@OgrenciId", yeniOgrenciGecmis.OgrenciId);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }
        public static bool GecmisOgretmenEkle(GecmisEgitim yeniOgretmenGecmis)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Ahmet_GecmisEgitim(MezuniyetYil,MezuniyetDerecesi,MezunOkul,OgretmenId) VALUES(@MezuniyetYil,@MezuniyetDerecesi,@MezunOkul,@OgretmenId)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@MezuniyetYil", yeniOgretmenGecmis.MezuniyetYil);
            cmd.Parameters.AddWithValue("@MezuniyetDerecesi", yeniOgretmenGecmis.MezuniyetDerecesi);
            cmd.Parameters.AddWithValue("@MezunOkul", yeniOgretmenGecmis.MezunOkul);
            cmd.Parameters.AddWithValue("@OgretmenId", yeniOgretmenGecmis.OgretmenId);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }
        public static bool GecmisMemurEkle(GecmisEgitim yeniMemurGecmis)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Ahmet_GecmisEgitim(MezuniyetYil,MezuniyetDerecesi,MezunOkul,MemurId) VALUES(@MezuniyetYil,@MezuniyetDerecesi,@MezunOkul,@MemurId)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@MezuniyetYil", yeniMemurGecmis.MezuniyetYil);
            cmd.Parameters.AddWithValue("@MezuniyetDerecesi", yeniMemurGecmis.MezuniyetDerecesi);
            cmd.Parameters.AddWithValue("@MezunOkul", yeniMemurGecmis.MezunOkul);
            cmd.Parameters.AddWithValue("@MemurId", yeniMemurGecmis.MemurId);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }
      
        
    }
}
