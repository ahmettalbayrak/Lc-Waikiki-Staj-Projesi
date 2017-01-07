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
    public partial class Ogretmen : Form
    {
        public Ogretmen()
        {
            InitializeComponent();
        }

        public static int OgretmenIdBul()
        {
            string kadi = GirisEkrani.kullaniciAdi;

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

        private void KisiseliGetir()
        {
            string kadi = GirisEkrani.kullaniciAdi;

            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT     Ahmet_Kisisel.TC, Ahmet_Kisisel.Ad, Ahmet_Kisisel.Soyad, Ahmet_Kisisel.DogumTarih, Ahmet_Kisisel.Mail, Ahmet_Kisisel.EvTel, Ahmet_Kisisel.CepTel, Ahmet_Kisisel.Unvan, Ahmet_Cinsiyet.Cinsiyet, Ahmet_MedeniDurum.MedeniDurum, Ahmet_GecmisEgitim.MezuniyetYil, Ahmet_GecmisEgitim.MezuniyetDerecesi, Ahmet_GecmisEgitim.MezunOkul,Ahmet_Ogretmen.IseBaslama, Ahmet_Ogretmen.GecmisDeneyimler FROM Ahmet_Cinsiyet INNER JOIN Ahmet_Kisisel ON Ahmet_Cinsiyet.CinsiyetId = Ahmet_Kisisel.CinsiyetId INNER JOIN Ahmet_MedeniDurum ON Ahmet_Kisisel.MedeniDurumId = Ahmet_MedeniDurum.MedeniDurumId INNER JOIN Ahmet_Ogretmen ON Ahmet_Kisisel.OgretmenId = Ahmet_Ogretmen.OgretmenId INNER JOIN Ahmet_GecmisEgitim ON Ahmet_Ogretmen.OgretmenId = Ahmet_GecmisEgitim.OgretmenId WHERE Ahmet_Kisisel.OgretmenId=@OgretmenId";
            cmd.Parameters.AddWithValue("@OgretmenId", OgretmenIdBul());
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
                txtGecmisDeneyimler.Text=reader["GecmisDeneyimler"].ToString();
            }

            pnlKisisel.Visible = true;
            pnlKisisel.Visible = true;
            pnlGecmisEgitim.Visible = true;
            pnlGecmisIs.Visible = true;
        }

        private void kişiselBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KisiseliGetir();
        }

        private void notGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotGiris notGiris = new NotGiris();
            notGiris.Show();   
        }

        private void Ogretmen_Load(object sender, EventArgs e)
        {
            KisiseliGetir();
        }

        private void Ogretmen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
