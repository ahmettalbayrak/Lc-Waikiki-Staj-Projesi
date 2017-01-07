using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class Bolum
    {
        public int BolumId { get; set; }
        public string Bolumm { get; set; }
        public override string ToString()
        {
            return this.Bolumm;
        }
        public int FakulteId { get; set; }

        public static int BolumIdBul()
        {
            string kadi = GirisEkrani.kullaniciAdi;
            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT OgrenciId FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            int ogrenciid = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandText = "SELECT BolumId FROM Ahmet_Ogrenci WHERE Ahmet_Ogrenci.OgrenciId=@OgrenciId";
            cmd.Parameters.AddWithValue("@OgrenciId", ogrenciid);
            int bolumid = Convert.ToInt32(cmd.ExecuteScalar());
            
            conn.Close();
            return bolumid;
        }

        public static int SinifiBul()
        {
            string kadi = GirisEkrani.kullaniciAdi;
            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT OgrenciId FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            int ogrenciid = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandText = "SELECT OgrenciSinifi FROM Ahmet_Ogrenci WHERE Ahmet_Ogrenci.OgrenciId=@OgrenciId";
            cmd.Parameters.AddWithValue("@OgrenciId", ogrenciid);
            int sinif = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return sinif;
        }
   }
}
