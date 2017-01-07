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

            cmd.CommandText = "SELECT Ahmet_Bolum.BolumId FROM Ahmet_Bolum INNER JOIN Ahmet_Ogrenci ON Ahmet_Bolum.BolumId = Ahmet_Ogrenci.BolumId INNER JOIN Ahmet_Kisisel ON Ahmet_Ogrenci.OgrenciId = Ahmet_Kisisel.OgrenciId WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            int bolumid = Convert.ToInt32(cmd.ExecuteScalar());
            
            //cmd.CommandText = "SELECT OgrenciId FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            //cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            //int ogrenciid = Convert.ToInt32(cmd.ExecuteScalar());

            //cmd.CommandText = "SELECT BolumId FROM Ahmet_Ogrenci WHERE Ahmet_Ogrenci.OgrenciId=@OgrenciId";
            //cmd.Parameters.AddWithValue("@OgrenciId", ogrenciid);
            //int bolumid = Convert.ToInt32(cmd.ExecuteScalar());
            
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
            cmd.CommandText = "SELECT Ahmet_Ogrenci.OgrenciSinifi FROM Ahmet_Ogrenci INNER JOIN Ahmet_Kisisel ON Ahmet_Ogrenci.OgrenciId = Ahmet_Kisisel.OgrenciId WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            int sinif = Convert.ToInt32(cmd.ExecuteScalar());

            //cmd.CommandText = "SELECT OgrenciId FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            //cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            //int ogrenciid = Convert.ToInt32(cmd.ExecuteScalar());

            //cmd.CommandText = "SELECT OgrenciSinifi FROM Ahmet_Ogrenci WHERE Ahmet_Ogrenci.OgrenciId=@OgrenciId";
            //cmd.Parameters.AddWithValue("@OgrenciId", ogrenciid);
            //int sinif = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return sinif;
        }

        public static List<Bolum> BolumDoldur(int yeni)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT BolumId,Bolum FROM Ahmet_Bolum WHERE Ahmet_Bolum.FakulteId=@FakulteId";
            cmd.Parameters.AddWithValue("@FakulteId", yeni);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Bolum> bolumler = new List<Bolum>();
            while (reader.Read())
            {
                Bolum bolum = new Bolum();
                {
                    bolum.BolumId = reader.GetInt32(0);
                    bolum.Bolumm = reader.GetString(1);
                    bolumler.Add(bolum);
                }
            }
            conn.Close();
            return bolumler;
        }

        
   }
}
