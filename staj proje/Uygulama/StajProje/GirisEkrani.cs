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
    public partial class GirisEkrani : Form
    {
        Ogrenci ogrenci = new Ogrenci();
        Ogretmen ogretmen = new Ogretmen();
        Veli veli = new Veli();
        Memur memur = new Memur();

        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            KullaniciTipiDoldur();
            cmbKullaniciTipi.SelectedIndex = 0;
        }

        private void KullaniciTipiDoldur()
        {
            SqlConnection conn = DbConncection.GetSqlConnection();

            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT KullaniciTipiId,Aciklama FROM Ahmet_KullaniciTipi";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                KullaniciTipi kullanicitipi = new KullaniciTipi()
                {
                    KullaniciTipiId = reader.GetInt32(0),
                    Aciklama = reader.GetString(1)
                };

                cmbKullaniciTipi.Items.Add(kullanicitipi);
            }

            conn.Close();
        }

        public static string kullaniciAdi;

        public void btnGiris_Click(object sender, EventArgs e)
        {
            kullaniciAdi = txtKullaniciAdi.Text;
            string kullaniciSifre = txtSifre.Text;
            var KullaniciSorgu = new Kisisel();
            
            KullaniciTipi secilenKullaniciTipi = (KullaniciTipi)cmbKullaniciTipi.SelectedItem;
            int secilenKullaniciTipiId = secilenKullaniciTipi.KullaniciTipiId;

            int gelensorgusonucu = Kisisel.KullaniciSorgula(kullaniciAdi, kullaniciSifre, secilenKullaniciTipiId);
            if (gelensorgusonucu == 1)
            {
                ogrenci.Show();
                this.Hide();
            }
            else if (gelensorgusonucu == 2)
            {
                ogretmen.Show();
                this.Hide();
            }

            else if (gelensorgusonucu == 3)
            {
                veli.Show();
                this.Hide();
            }
            else if (gelensorgusonucu == 4)
            {
                memur.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Geçersiz Kullanıcı Adı, Şifre ve Kullanıcı Tipi Kombinasyonu");
        }   
    }
}