using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class VeliTablo
    {
        public int VeliId { get; set; }
        public int OgrenciId { get; set; }
        public string OgrenciNo { get; set; }

        public static bool VeliTabloEkle(VeliTablo yeniVeliTablo)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Ahmet_Veli(OgrenciNo,OgrenciId) VALUES(@OgrenciNo,@OgrenciId)";
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.AddWithValue("@OgrenciNo", yeniVeliTablo.OgrenciNo);
            cmd.Parameters.AddWithValue("@OgrenciId", yeniVeliTablo.OgrenciId);          
            
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }
        
        public static int VeliOgrenciIdBul(VeliTablo yeniOgrenciId)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT OgrenciId FROM Ahmet_Ogrenci WHERE OgrenciNo=@OgrenciNo ";
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.
            AddWithValue("@OgrenciNo", yeniOgrenciId.OgrenciNo);
            int ogrenciId = Convert.ToInt32(cmd.ExecuteScalar());
            
            conn.Close();
            return ogrenciId;   
        }

        public static int VeliIdBul()
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MAX(VeliId) FROM Ahmet_Veli";
            cmd.Connection = conn;
            conn.Open();
            int veliid = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return veliid;
        }

    }
}
