using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class OgretmenTablo
    {
        public int OgretmenId { get; set; }
        public DateTime IseBaslama { get; set; }
        public string GecmisDeneyimler { get; set; }

        public static bool OgretmenTabloEkle(OgretmenTablo yeniOgretmenTablo)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Ahmet_Ogretmen(IseBaslama,GecmisDeneyimler) VALUES(@IseBalama,@GecmisDeneyimler)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@IseBalama", yeniOgretmenTablo.IseBaslama);
            cmd.Parameters.AddWithValue("@GecmisDeneyimler", yeniOgretmenTablo.GecmisDeneyimler);
            conn.Open();

            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }

        public static int OgretmenIdBul()
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MAX(OgretmenId) FROM Ahmet_Ogretmen";
            cmd.Connection = conn;
            conn.Open();

            int ogretmenid = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return ogretmenid;
        }

        public static int OgretmenIdBul2()
        {
            string kadi=GirisEkrani.kullaniciAdi;
            
            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT OgretmenId FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            int ogretmenid = Convert.ToInt32(cmd.ExecuteScalar());
            
            conn.Close();
            return ogretmenid;   
        }
    }
}
