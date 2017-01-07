using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajProje
{
    public partial class DersSecim : Form
    {

        public DersSecim()
        {
            InitializeComponent();
        }
        
        List<Dersler> dersler = new List<Dersler>();
        //private static List<Dersler> SecilenDersleriGetir()
        //{
        //    int ogrenciid = OgrenciIdBul();
        //    SqlConnection conn = DbConncection.GetSqlConnection();
        //    var cmd = new SqlCommand();
        //    cmd.Connection = conn;
        //    conn.Open();     
        //        cmd.Parameters.Clear();
        //        cmd.CommandText = "SELECT Ahmet_SecilenDersler.DerslerId, Ahmet_Dersler.DersAdi FROM  Ahmet_Dersler INNER JOIN Ahmet_SecilenDersler ON Ahmet_Dersler.DerslerId = Ahmet_SecilenDersler.DerslerId INNER JOIN Ahmet_Ogrenci ON Ahmet_SecilenDersler.OgrenciId = Ahmet_Ogrenci.OgrenciId WHERE Ahmet_SecilenDersler.OgrenciId=@OgrenciId";
        //        cmd.Parameters.AddWithValue("@OgrenciId", ogrenciid);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        List<Dersler> dersler = new List<Dersler>();
        //        while (reader.Read())
        //        {
        //            Dersler ders = new Dersler();
        //            {
        //                ders.DerslerId = reader.GetInt32(0);
        //                ders.DersAdi = reader.GetString(1);
        //                dersler.Add(ders);  
        //            }
        //        }
        //        conn.Close();
        //        return dersler;
        //}

        private void SecilenDersleriGetir()
        {
            int ogrenciid = OgrenciIdBul();
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "SELECT COUNT(*) FROM Ahmet_SecilenDersler WHERE Ahmet_SecilenDersler.OgrenciId=@OgrenciId";
            cmd.Parameters.AddWithValue("@OgrenciId", ogrenciid);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int kayitsayisi = reader.GetInt32(0);

            int[] dizi = new int[kayitsayisi];
            int j = 0;
            reader.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT DerslerId FROM Ahmet_SecilenDersler WHERE Ahmet_SecilenDersler.OgrenciId=@OgrenciId ";
            cmd.Parameters.AddWithValue("@OgrenciId", ogrenciid);

            //ConnectionState acikmi = conn.State;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dizi[j] = rdr.GetInt32(0);
                j++;
            }
            rdr.Close();

            for (int i = 0; i < kayitsayisi; i++)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT DerslerId,DersAdi FROM Ahmet_Dersler WHERE Ahmet_Dersler.DerslerId=@DerslerId";
                cmd.Parameters.AddWithValue("@DerslerId", dizi[i]);
                SqlDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    Dersler dersler = new Dersler();
                    {
                        dersler.DerslerId = reader2.GetInt32(0);
                        dersler.DersAdi = reader2.GetString(1);
                    }
                    lsbSecilenDersler.Items.Add(dersler);
                }
                reader2.Close();
            }
            conn.Close();
        }
            
        private void DersleriGetir()
        {
            int bolumid = Bolum.BolumIdBul();
            int sinif = Bolum.SinifiBul();
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT DerslerId,DersAdi FROM Ahmet_Dersler WHERE Ahmet_Dersler.BolumId=@BolumId and Ahmet_Dersler.Sinif=@Sinif ";
            cmd.Parameters.AddWithValue("@BolumId", bolumid);
            cmd.Parameters.AddWithValue("@Sinif", sinif);
            
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Dersler dersler = new Dersler();
                {
                    dersler.DerslerId = reader.GetInt32(0);
                    dersler.DersAdi = reader.GetString(1);
                }
                int a = 0; 
                foreach (Dersler item in lsbSecilenDersler.Items)
                {
                    if (dersler.DerslerId == item.DerslerId)
                    {
                         a = 1;
                    }
                }
                if (a!=1)
                {
                lsbTumDersler.Items.Add(dersler);  
                } 
            }
            conn.Close();
        }

        private void DersSil()
        {
            int ogrenciid = OgrenciIdBul();
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "DELETE FROM Ahmet_SecilenDersler WHERE Ahmet_SecilenDersler.OgrenciId=@OgrenciId ";
            cmd.Parameters.AddWithValue("@OgrenciId",ogrenciid);
            cmd.ExecuteNonQuery();
            conn.Close();           
        }

        private void SecilenDersEkleme(int dersId)
        {
            int ogrenciid = OgrenciIdBul();
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO Ahmet_SecilenDersler (DerslerId,OgrenciId) VALUES(@DerslerId,@OgrenciId)";
            cmd.Parameters.AddWithValue("@DerslerId", dersId);
            cmd.Parameters.AddWithValue("@OgrenciId", ogrenciid);
            cmd.ExecuteNonQuery();
            
            conn.Close();    
        }

        public static int OgrenciIdBul()
        {
            string kadi = GirisEkrani.kullaniciAdi;

            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.CommandText = "SELECT OgrenciId FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            cmd.Connection = conn;
            int ogrenciid = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return ogrenciid;
        }

        private void DersSecim_Load(object sender, EventArgs e)
        {
            SecilenDersleriGetir();
            DersleriGetir();       
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lsbSecilenDersler.Items.Add(lsbTumDersler.SelectedItem);
            lsbTumDersler.Items.Remove(lsbTumDersler.SelectedItem);    
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            lsbTumDersler.Items.Add(lsbSecilenDersler.SelectedItem);
            lsbSecilenDersler.Items.Remove(lsbSecilenDersler.SelectedItem);            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DersSil();

            foreach (Dersler item in lsbSecilenDersler.Items)
            {
                SecilenDersEkleme(item.DerslerId);
            }
            MessageBox.Show("Kayıt tamamlandı");
        }
    }
}

