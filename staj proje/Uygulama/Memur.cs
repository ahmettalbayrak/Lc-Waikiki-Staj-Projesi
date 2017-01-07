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
    public partial class Memur : Form
    {
        public Memur()
        {
            InitializeComponent();
        }

        KayıtEkle kayıtEkle = new KayıtEkle();

        DersEkle dersEkle = new DersEkle();

        private void kişiselBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiseliGetir();
        }
        
        private void Memur_Load(object sender, EventArgs e)
        {
            KisiseliGetir();
        }

        private void kullanıcıKayıtİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayıtEkle kayıtEkle = new KayıtEkle();
            kayıtEkle.Show();
            
        }

        private void KisiseliGetir()
        {
            string kadi = GirisEkrani.kullaniciAdi;

            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT     Ahmet_Kisisel.TC, Ahmet_Kisisel.Ad, Ahmet_Kisisel.Soyad, Ahmet_Kisisel.DogumTarih, Ahmet_Kisisel.Mail, Ahmet_Kisisel.EvTel, Ahmet_Kisisel.Unvan, Ahmet_Kisisel.CepTel, Ahmet_Cinsiyet.Cinsiyet, Ahmet_MedeniDurum.MedeniDurum, Ahmet_GecmisEgitim.MezuniyetYil, Ahmet_GecmisEgitim.MezuniyetDerecesi, Ahmet_GecmisEgitim.MezunOkul, Ahmet_Memur.IseBaslama, Ahmet_Memur.GecmisDeneyimler FROM Ahmet_Cinsiyet INNER JOIN Ahmet_Kisisel ON Ahmet_Cinsiyet.CinsiyetId = Ahmet_Kisisel.CinsiyetId INNER JOIN Ahmet_MedeniDurum ON Ahmet_Kisisel.MedeniDurumId = Ahmet_MedeniDurum.MedeniDurumId INNER JOIN Ahmet_Memur ON Ahmet_Kisisel.MemurId = Ahmet_Memur.MemurId INNER JOIN Ahmet_GecmisEgitim ON Ahmet_Memur.MemurId = Ahmet_GecmisEgitim.MemurId WHERE Ahmet_Kisisel.MemurId=@MemurId";
            cmd.Parameters.AddWithValue("@MemurId", MemurIdBul());
            cmd.Connection = conn;
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtTc.Text = reader["TC"].ToString();
                txtAd.Text = reader["Ad"].ToString();
                txtSoyad.Text = reader["Soyad"].ToString();
                txtDogumTarihi.Text = reader.GetDateTime(3).ToShortDateString();
                txtCinsiyet.Text = reader["Cinsiyet"].ToString();
                txtMedeniDurum.Text = reader["MedeniDurum"].ToString();
                txtMail.Text = reader["Mail"].ToString();
                txtEvTel.Text = reader["EvTel"].ToString();
                txtCepTel.Text = reader["CepTel"].ToString();
                txtUnvan.Text = reader["Unvan"].ToString();
                txtGecmisOkul.Text = reader["MezunOkul"].ToString();
                txtMezuniyetYil.Text = reader["MezuniyetYil"].ToString();
                txtMezuniyetDerecesi.Text = reader["MezuniyetDerecesi"].ToString();
                txtIseBaslama.Text = reader.GetDateTime(13).ToShortDateString();
                txtGecmisDeneyimler.Text = reader["GecmisDeneyimler"].ToString();
            }
            pnlKisisel.Visible = true;
            pnlKisisel.Visible = true;
            pnlGecmisEgitim.Visible = true;
            pnlGecmisIs.Visible = true;
        }

        public static int MemurIdBul()
        {
            string kadi = GirisEkrani.kullaniciAdi;

            SqlConnection conn = DbConncection.GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.CommandText = "SELECT MemurId FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.KullaniciAdi=@KullaniciAdi";
            cmd.Parameters.AddWithValue("@KullaniciAdi", kadi);
            cmd.Connection = conn;
            int memurid = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return memurid;
        }

        private void dersEklemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersEkle dersEkle = new DersEkle();
            dersEkle.Show();
        }

        private void Memur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       
    }
}
