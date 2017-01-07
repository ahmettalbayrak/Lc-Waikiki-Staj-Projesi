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
    public partial class KayıtEkle : Form
    {
        public KayıtEkle()
        {
            InitializeComponent();
        }

        private void KayitTipiDoldur()
        {
            SqlConnection conn = DbConncection.GetSqlConnection();

            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT KullaniciTipiId,Aciklama FROM Ahmet_KullaniciTipi";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                KullaniciTipi kullanicitipi = new KullaniciTipi();
                {

                    kullanicitipi.KullaniciTipiId = reader.GetInt32(0);
                    kullanicitipi.Aciklama = reader.GetString(1);
                }

                cmbKayıtTipi.Items.Add(kullanicitipi);
            }

            conn.Close();
            cmbKayıtTipi.SelectedIndex = 0;
        }

        private void MedeniDurumDoldur()
        {
            SqlConnection conn = DbConncection.GetSqlConnection();

            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT MedeniDurumId,MedeniDurum FROM Ahmet_MedeniDurum";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MedeniDurum medenidurum = new MedeniDurum();
                {

                    medenidurum.MedeniDurumId = reader.GetInt32(0);
                    medenidurum.MedeniDurumu = reader.GetString(1);
                }

                cmbMedeniDurum.Items.Add(medenidurum);
            }

            conn.Close();
            cmbMedeniDurum.SelectedIndex = 0;
        }

        private void CinsiyetDoldur()
        {
            SqlConnection conn = DbConncection.GetSqlConnection();

            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT CinsiyetId,Cinsiyet FROM Ahmet_Cinsiyet";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Cinsiyet cinsiyet = new Cinsiyet();
                {

                    cinsiyet.CinsiyetId = reader.GetInt32(0);
                    cinsiyet.Cinsiyeti = reader.GetString(1);
                }

                cmbCinsiyet.Items.Add(cinsiyet);
            }

            conn.Close();
            cmbCinsiyet.SelectedIndex = 0;
        }

        private void MezuniyetYilDoldur()
        {
            for (int i = 1980; i <= DateTime.Now.Year; i++)
            {
                cmbMezuniyetYil.Items.Add(i);

            }
            cmbMezuniyetYil.SelectedIndex = 0; 
        }

        private void OkulaGirisiDoldur()
        {
            for (int i = 1980; i < DateTime.Now.Year; i++)
            {

                cmbOkulaGirisDonemi.Items.Add(i + "-" + (i + 1));
            }
            cmbOkulaGirisDonemi.SelectedIndex = 0;
        }

        private void FakulteDoldur() //2 tane
        {
            //cmbFakulte.ValueMember = "FakulteId";
            //cmbFakulte.DisplayMember = "Fakultee";
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT FakulteId,Fakulte FROM Ahmet_Fakulte";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Fakulte fakulte = new Fakulte();
                {
                    fakulte.FakulteId = reader.GetInt32(0);
                    fakulte.Fakultee = reader.GetString(1);
                }
                cmbFakulte.Items.Add(fakulte);
            }
            conn.Close();
            cmbFakulte.SelectedIndex = 0;
        }

        private void BolumDoldur()//2 tane
        {
            //cmbBolum.ValueMember = "BolumId";
            //cmbBolum.DisplayMember = "Bolumm";
            SqlConnection conn = DbConncection.GetSqlConnection();
            Fakulte secilen = (Fakulte)cmbFakulte.SelectedItem;
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Ahmet_Bolum WHERE FakulteId=@fakulteId ";
            cmd.Parameters.AddWithValue("@fakulteId", secilen.FakulteId);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Bolum bolum = new Bolum();
                {
                    bolum.BolumId = reader.GetInt32(0);
                    bolum.Bolumm = reader.GetString(1);
                }

                cmbBolum.Items.Add(bolum);
            }

            conn.Close();
            cmbBolum.SelectedIndex = 0;
        }

        private void SinifiDoldur()//2 tane
        {
            for (int i = 1; i < 5; i++)
            {


                cmbOgrenciSinif.Items.Add(i );
            }
            cmbOgrenciSinif.SelectedIndex = 0;
        }

        private void cmbKayıtTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBolum.Items.Clear();
            cmbFakulte.Items.Clear();
            cmbOkulaGirisDonemi.Items.Clear();
            cmbMezuniyetYil.Items.Clear();
            cmbMedeniDurum.Items.Clear();
            cmbCinsiyet.Items.Clear();
            cmbOgrenciSinif.Items.Clear();
            Temizle();
            if (((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId == 1)
            {


                pnlGecmisEgitim.Visible = true;
                pnlOkulaGiris.Visible = true;
                pnlOgrenciBilgisi.Visible = true;
                pnliseBaslama.Visible = false;
                pnlSabitler.Visible = true;
                btnKayıtEkle.Visible = true;
                CinsiyetDoldur();
                MedeniDurumDoldur();
                MezuniyetYilDoldur();
                OkulaGirisiDoldur();
                FakulteDoldur();

                SinifiDoldur();

            }
            if (((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId == 2)
            {

                pnlGecmisEgitim.Visible = true;
                pnlOkulaGiris.Visible = false;
                pnlOgrenciBilgisi.Visible = false;
                pnliseBaslama.Visible = true;
                pnlSabitler.Visible = true;
                btnKayıtEkle.Visible = true;
                CinsiyetDoldur();
                MedeniDurumDoldur();
                MezuniyetYilDoldur();

            }
            if (((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId == 3)
            {
                pnlGecmisEgitim.Visible = false;
                pnlOkulaGiris.Visible = false;
                pnlOgrenciBilgisi.Visible = true;
                pnliseBaslama.Visible = false;
                pnlSabitler.Visible = true;
                btnKayıtEkle.Visible = true;
                CinsiyetDoldur();
                MedeniDurumDoldur();

            }
            if (((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId == 4)
            {
                pnlGecmisEgitim.Visible = true;
                pnlOkulaGiris.Visible = false;
                pnlOgrenciBilgisi.Visible = false;
                pnliseBaslama.Visible = true;
                pnlSabitler.Visible = true;
                btnKayıtEkle.Visible = true;
                CinsiyetDoldur();
                MedeniDurumDoldur();
                MezuniyetYilDoldur();

            }
        }

        private void Temizle()
        {
            txtOgrenciNo.Text = "";
            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtmail.Text = "";
            txtEvTel.Text = "";
            txtCepTel.Text = "";
            txtUnvan.Text = "";
            txtGecmisOkul.Text = "";
            txtMezuniyetDerecesi.Text = "";
            txtGecmisDeneyimler.Text = "";
            cmbOkulaGirisDonemi.Items.Clear();
            cmbOgrenciSinif.Items.Clear();
            cmbFakulte.Items.Clear();
            cmbBolum.Items.Clear();
            cmbCinsiyet.Items.Clear();
            cmbMedeniDurum.Items.Clear();
            cmbMezuniyetYil.Items.Clear();

        }

        private void btnKayıtEkle_Click(object sender, EventArgs e)
        {
             if (((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId==1)
            {
                OgrenciTablo ogrencitablo = new OgrenciTablo();
                ogrencitablo.OgrenciNo = txtOgrenciNo.Text;
                ogrencitablo.OkulaGirisDonemi = ((String)cmbOkulaGirisDonemi.SelectedItem);
                ogrencitablo.OgrenciSinifi = ((Int32)cmbOgrenciSinif.SelectedItem);
                ogrencitablo.FakulteId = ((Fakulte)cmbFakulte.SelectedItem).FakulteId;
                ogrencitablo.BolumId = ((Bolum)cmbBolum.SelectedItem).BolumId;
                OgrenciTablo.OgrenciTabloEkle(ogrencitablo);
                
                Kisisel ogrencikisisel = new Kisisel();
                ogrencikisisel.TC = txtTc.Text;
                ogrencikisisel.Ad = txtAd.Text;
                ogrencikisisel.Soyad = txtSoyad.Text;
                ogrencikisisel.DogumTarih = datetimeDogumTarih.Value;
                ogrencikisisel.CinsiyetId = ((Cinsiyet)cmbCinsiyet.SelectedItem).CinsiyetId;
                ogrencikisisel.MedeniDurumId = ((MedeniDurum)cmbMedeniDurum.SelectedItem).MedeniDurumId;
                ogrencikisisel.Mail = txtmail.Text;
                ogrencikisisel.EvTel = txtEvTel.Text;
                ogrencikisisel.CepTel = txtCepTel.Text;
                ogrencikisisel.Unvan = txtUnvan.Text;
                ogrencikisisel.KullaniciTipiId = ((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId;
                ogrencikisisel.KullaniciAdi = ogrencitablo.OgrenciNo;
                ogrencikisisel.Sifre = ogrencikisisel.TC;
                ogrencikisisel.OgrenciId = OgrenciTablo.OgrenciIdBul(ogrencitablo);
                Kisisel.KisiselOgrenciEkle(ogrencikisisel);
                

                GecmisEgitim gecmis = new GecmisEgitim();
                gecmis.MezuniyetYil = ((Int32)cmbMezuniyetYil.SelectedItem);
                gecmis.MezuniyetDerecesi = Convert.ToDouble(txtMezuniyetDerecesi.Text);
                gecmis.MezunOkul = txtGecmisOkul.Text;
                gecmis.OgrenciId = OgrenciTablo.OgrenciIdBul(ogrencitablo);
                GecmisEgitim.GecmisOgrenciEkle(gecmis);

                txtOgrenciNo.Text = "";
                

                MessageBox.Show("Öğrenci Kaydedildi");
            }
            if (((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId == 2)
            {
                OgretmenTablo ogretmentablo = new OgretmenTablo();
                ogretmentablo.IseBaslama = datetimeIseBaslama.Value;
                ogretmentablo.GecmisDeneyimler = txtGecmisDeneyimler.Text;
                OgretmenTablo.OgretmenTabloEkle(ogretmentablo);

                Kisisel ogretmenkisisel = new Kisisel();
                ogretmenkisisel.TC = txtTc.Text;
                ogretmenkisisel.Ad = txtAd.Text;
                ogretmenkisisel.Soyad = txtSoyad.Text;
                ogretmenkisisel.DogumTarih = datetimeDogumTarih.Value;
                ogretmenkisisel.CinsiyetId = ((Cinsiyet)cmbCinsiyet.SelectedItem).CinsiyetId;
                ogretmenkisisel.MedeniDurumId = ((MedeniDurum)cmbMedeniDurum.SelectedItem).MedeniDurumId;
                ogretmenkisisel.Mail = txtmail.Text;
                ogretmenkisisel.EvTel = txtEvTel.Text;
                ogretmenkisisel.CepTel = txtCepTel.Text;
                ogretmenkisisel.Unvan = txtUnvan.Text;
                ogretmenkisisel.KullaniciTipiId = ((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId;
                ogretmenkisisel.OgretmenId = OgretmenTablo.OgretmenIdBul();
                ogretmenkisisel.KullaniciAdi = ogretmenkisisel.TC;
                ogretmenkisisel.Sifre = ogretmenkisisel.TC;
                Kisisel.KisiselOgretmenEkle(ogretmenkisisel);

                GecmisEgitim gecmis = new GecmisEgitim();

                gecmis.MezuniyetYil = ((Int32)cmbMezuniyetYil.SelectedItem);
                gecmis.MezuniyetDerecesi = Convert.ToDouble(txtMezuniyetDerecesi.Text);
                gecmis.MezunOkul = txtGecmisOkul.Text;
                gecmis.OgretmenId = OgretmenTablo.OgretmenIdBul();
                GecmisEgitim.GecmisOgretmenEkle(gecmis);
                
                MessageBox.Show("Öğretmen Kaydedildi");
            }
            if (((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId == 3)
            {
                VeliTablo velitablo = new VeliTablo();
                velitablo.OgrenciNo = txtOgrenciNo.Text;
                velitablo.OgrenciId = VeliTablo.VeliOgrenciIdBul(velitablo);
                VeliTablo.VeliTabloEkle(velitablo);

                Kisisel velikisisel = new Kisisel();
                velikisisel.TC = txtTc.Text;
                velikisisel.Ad = txtAd.Text;
                velikisisel.Soyad = txtSoyad.Text;
                velikisisel.DogumTarih = datetimeDogumTarih.Value;
                velikisisel.CinsiyetId = ((Cinsiyet)cmbCinsiyet.SelectedItem).CinsiyetId;
                velikisisel.MedeniDurumId = ((MedeniDurum)cmbMedeniDurum.SelectedItem).MedeniDurumId;
                velikisisel.Mail = txtmail.Text;
                velikisisel.EvTel = txtEvTel.Text;
                velikisisel.CepTel = txtCepTel.Text;
                velikisisel.Unvan = txtUnvan.Text;
                velikisisel.KullaniciTipiId = ((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId;
                velikisisel.VeliId = VeliTablo.VeliIdBul();
                velikisisel.KullaniciAdi = velikisisel.TC;
                velikisisel.Sifre = velikisisel.TC;
                Kisisel.KisiselVeliEkle(velikisisel);
                
                MessageBox.Show("Veli Kaydedildi");
            }
            if (((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId == 4)
            {
                MemurTablo memurtablo = new MemurTablo();
                memurtablo.IseBaslama = datetimeIseBaslama.Value;
                memurtablo.GecmisDeneyimler = txtGecmisDeneyimler.Text;
                MemurTablo.MemurTabloEkle(memurtablo);
                
                Kisisel memurkisisel = new Kisisel();
                memurkisisel.TC = txtTc.Text;
                memurkisisel.Ad = txtAd.Text;
                memurkisisel.Soyad = txtSoyad.Text;
                memurkisisel.DogumTarih = datetimeDogumTarih.Value;
                memurkisisel.CinsiyetId = ((Cinsiyet)cmbCinsiyet.SelectedItem).CinsiyetId;
                memurkisisel.MedeniDurumId = ((MedeniDurum)cmbMedeniDurum.SelectedItem).MedeniDurumId;
                memurkisisel.Mail = txtmail.Text;
                memurkisisel.EvTel = txtEvTel.Text;
                memurkisisel.CepTel = txtCepTel.Text;
                memurkisisel.Unvan = txtUnvan.Text;
                memurkisisel.KullaniciTipiId = ((KullaniciTipi)cmbKayıtTipi.SelectedItem).KullaniciTipiId;
                memurkisisel.MemurId = MemurTablo.MemurIdBul();
                memurkisisel.KullaniciAdi = memurkisisel.TC;
                memurkisisel.Sifre = memurkisisel.TC;
                Kisisel.KisiselMemurEkle(memurkisisel);

                GecmisEgitim gecmis = new GecmisEgitim();
                gecmis.MezuniyetYil = ((Int32)cmbMezuniyetYil.SelectedItem);
                gecmis.MezuniyetDerecesi = Convert.ToDouble(txtMezuniyetDerecesi.Text);
                gecmis.MezunOkul = txtGecmisOkul.Text;
                gecmis.MemurId = MemurTablo.MemurIdBul();
                GecmisEgitim.GecmisMemurEkle(gecmis);
               
                MessageBox.Show("MemurKaydedildi");
                }
            Temizle();
        }

        private void KayıtEkle_Load(object sender, EventArgs e)
        {
            
            pnlKayitTipi.Visible = true;
            pnlGecmisEgitim.Visible = false;
            pnlOkulaGiris.Visible = false;
            pnlOgrenciBilgisi.Visible = false;
            pnliseBaslama.Visible = false;
            pnlSabitler.Visible = false;
            btnKayıtEkle.Visible = false;
            KayitTipiDoldur();
            

        }

        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            BolumDoldur();
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtOgrenciNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }
    }
}
