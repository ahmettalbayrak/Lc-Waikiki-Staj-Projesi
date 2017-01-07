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
    public partial class Veli : Form
    {
        public Veli()
        {
            InitializeComponent();
        }

        private void Veli_Load(object sender, EventArgs e)
        {
            KisiseliGetir();
        }
        
        private void KisiseliGetir()
        {
            string kadi = GirisEkrani.kullaniciAdi;
            
            SqlConnection conn = DbConncection.GetSqlConnection();

            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {   
                txtTc.Text = reader["TC"].ToString();
                txtAd.Text = reader["Ad"].ToString();
                txtSoyad.Text = reader["Soyad"].ToString();
                txtDogumTarihi.Text = reader["DogumTarih"].ToString();
                int cinsiyetid = Convert.ToInt32(reader["CinsiyetId"].ToString());
                CinsiyetAciklama(cinsiyetid);
                int medenidurumid = Convert.ToInt32(reader["MedeniDurumId"].ToString());
                MedeniDurumAciklama(medenidurumid);
                txtMail.Text = reader["Mail"].ToString();
                txtEvTel.Text = reader["EvTel"].ToString();
                txtCepTel.Text = reader["CepTel"].ToString();
                txtUnvan.Text = reader["Unvan"].ToString();
            }
            //cmd.ExecuteNonQuery();
            conn.Close();
            pnlNotlar.Visible = false;
            pnlKisisel.Visible = true;
        }
        
        private void NotlariGetir()
        {
            DataTable tablo = new DataTable();
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "SELECT     Ahmet_Ogrenci.OgrenciNo, Ahmet_Dersler.DersAdi, Ahmet_Notlar.Vize, Ahmet_Notlar.Final, Ahmet_Notlar.Ortalama FROM Ahmet_Dersler INNER JOIN Ahmet_Notlar ON Ahmet_Dersler.DerslerId = Ahmet_Notlar.DerslerId INNER JOIN Ahmet_Ogrenci ON Ahmet_Notlar.OgrenciId=Ahmet_Ogrenci.OgrenciId WHERE Ahmet_Notlar.OgrenciId=@OgrenciId";
            cmd.Parameters.AddWithValue("@OgrenciId", OgrenciIdBul());
            SqlDataReader reader = cmd.ExecuteReader();
            tablo.Load(reader);

            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].HeaderText = "Ogrenci Numarası";
            dataGridView1.Columns[1].HeaderText = "Ders Adı";
            dataGridView1.Columns[2].HeaderText = "Vize";
            dataGridView1.Columns[3].HeaderText = "Final";
            dataGridView1.Columns[4].HeaderText = "Ortalama";

            pnlKisisel.Visible = false;
            pnlNotlar.Visible = true;
        }

        private void CinsiyetAciklama(int cinsiyetid)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();

            var cmd = new SqlCommand();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT Cinsiyet FROM Ahmet_Cinsiyet WHERE Ahmet_Cinsiyet.CinsiyetId=@CinsiyetId";
            cmd.Parameters.AddWithValue("@CinsiyetId", cinsiyetid);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtCinsiyet.Text = reader.GetString(0);
            }
            conn.Close();
        }

        private void MedeniDurumAciklama(int medenidurumid)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();

            var cmd = new SqlCommand();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT MedeniDurum FROM Ahmet_MedeniDurum WHERE Ahmet_MedeniDurum.MedeniDurumId=@MedeniDurumId";
            cmd.Parameters.AddWithValue("@MedeniDurumId", medenidurumid);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtMedeniDurum.Text = reader.GetString(0);
            }
            conn.Close();
        }

        private void kişiselBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiseliGetir();   
        }

        public static int OgrenciIdBul()
        {
            string kadi = GirisEkrani.kullaniciAdi;

            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.Open();
            cmd.CommandText = "SELECT VeliId FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            cmd.Connection = conn;
            int veliid = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT OgrenciId FROM Ahmet_Veli WHERE Ahmet_Veli.VeliId=@VeliId";
            cmd.Parameters.AddWithValue("@VeliId", veliid);

            int ogrenciid = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return ogrenciid;
        }

        private void öğrenciNotlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotlariGetir();
        }
    }
}
