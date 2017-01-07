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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
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

        private void KisiseliGetir()
        {
            string kadi = GirisEkrani.kullaniciAdi;

            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT     Ahmet_Kisisel.TC, Ahmet_Kisisel.Ad, Ahmet_Kisisel.Soyad, Ahmet_Kisisel.DogumTarih, Ahmet_Kisisel.Mail, Ahmet_Kisisel.EvTel, Ahmet_Kisisel.CepTel, Ahmet_Kisisel.Unvan, Ahmet_Cinsiyet.Cinsiyet, Ahmet_MedeniDurum.MedeniDurum, Ahmet_GecmisEgitim.MezunOkul, Ahmet_GecmisEgitim.MezuniyetYil, Ahmet_GecmisEgitim.MezuniyetDerecesi, Ahmet_Fakulte.Fakulte, Ahmet_Bolum.Bolum, Ahmet_Ogrenci.OkulaGirisDonemi, Ahmet_Ogrenci.OgrenciSinifi FROM Ahmet_Kisisel INNER JOIN Ahmet_Cinsiyet ON Ahmet_Kisisel.CinsiyetId = Ahmet_Cinsiyet.CinsiyetId INNER JOIN Ahmet_MedeniDurum ON Ahmet_Kisisel.MedeniDurumId = Ahmet_MedeniDurum.MedeniDurumId INNER JOIN Ahmet_Ogrenci ON Ahmet_Kisisel.OgrenciId = Ahmet_Ogrenci.OgrenciId INNER JOIN Ahmet_Bolum INNER JOIN Ahmet_Fakulte ON Ahmet_Bolum.FakulteId = Ahmet_Fakulte.FakulteId ON Ahmet_Ogrenci.BolumId = Ahmet_Bolum.BolumId AND Ahmet_Ogrenci.FakulteId = Ahmet_Fakulte.FakulteId INNER JOIN Ahmet_GecmisEgitim ON Ahmet_Ogrenci.OgrenciId = Ahmet_GecmisEgitim.OgrenciId WHERE Ahmet_Kisisel.OgrenciId=@OgrenciId";
            cmd.Parameters.AddWithValue("@OgrenciId", OgrenciIdBul());
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtTc.Text = reader["TC"].ToString();
                txtAd.Text = reader["Ad"].ToString();
                txtSoyad.Text = reader["Soyad"].ToString();
                txtDogumTarihi.Text = reader["DogumTarih"].ToString();
                txtCinsiyet.Text=reader["Cinsiyet"].ToString();
                txtMedeniDurum.Text=reader["MedeniDurum"].ToString();
                txtMail.Text = reader["Mail"].ToString();
                txtEvTel.Text = reader["EvTel"].ToString();
                txtCepTel.Text = reader["CepTel"].ToString();
                txtUnvan.Text = reader["Unvan"].ToString();
                txtGecmisOkul.Text=reader["MezunOkul"].ToString();
                txtMezuniyetYil.Text=reader["MezuniyetYil"].ToString();
                txtMezuniyetDerecesi.Text=reader["MezuniyetDerecesi"].ToString();
                txtOkulaGiris.Text=reader["OkulaGirisDonemi"].ToString();
                txtFakulte.Text=reader["Fakulte"].ToString();
                txtBolum.Text=reader["Bolum"].ToString();
                txtSinif.Text=reader["OgrenciSinifi"].ToString();
                
            }
            //cmd.ExecuteNonQuery();
            conn.Close();
            pnlNotlar.Visible = false;
            pnlKisisel.Visible = true;
            pnlOkulaGiris.Visible = true;
            pnlGecmisEgitim.Visible = true;
            pnlSabitler.Visible = true;
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
            pnlOkulaGiris.Visible = false;
            pnlGecmisEgitim.Visible = false;
            pnlSabitler.Visible = false;
            pnlNotlar.Visible = true;
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            KisiseliGetir();
        }

        private void kişiselBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlNotlar.Visible = false;
            pnlKisisel.Visible = true;
            pnlOkulaGiris.Visible = true;
            pnlGecmisEgitim.Visible = true;
            pnlSabitler.Visible = true;
            KisiseliGetir();
        }

        private void dersSeçimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersSecim derssecim = new DersSecim();
            derssecim.Show();
        }

        private void notlarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotlariGetir();
        }       
    }
}
