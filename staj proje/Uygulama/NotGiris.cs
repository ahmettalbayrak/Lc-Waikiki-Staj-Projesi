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
    public partial class NotGiris : Form
    {
        public NotGiris()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            txtVize.Text = "";
            txtFinal.Text = "";
            txtAdSoyad.Text = "";
            txtOrtalama.Text = "";
            txtOgrenciNo.Text = "";
            cmbDersAdi.Items.Clear();
            cmbDersAdi.Text = "";  
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OgrenciTablo ogrencitablo = new OgrenciTablo();
            ogrencitablo.OgrenciNo = txtOgrenciNo.Text;

            if (txtVize.Text!="" && txtFinal.Text!="")
            {
                NotlarTablo notlartablo = new NotlarTablo();

                notlartablo.OgrenciId = OgrenciTablo.OgrenciIdBul(ogrencitablo);
                notlartablo.DerslerId = ((Dersler)cmbDersAdi.SelectedItem).DerslerId;
                notlartablo.Vize = Convert.ToInt32(txtVize.Text);
                notlartablo.Final = Convert.ToInt32(txtFinal.Text);
                notlartablo.Ortalama = Convert.ToInt32((notlartablo.Vize * 0.3) + (notlartablo.Final * 0.7));
                NotlarTablo.NotFinalOrtalama(notlartablo);
                MessageBox.Show("Not giriş işlemi başarılı");
            }
            else if (txtVize.Text!="" && txtFinal.Text=="")
            {
                NotlarTablo notlartablo = new NotlarTablo();
                notlartablo.OgrenciId = OgrenciTablo.OgrenciIdBul(ogrencitablo);
                notlartablo.DerslerId = ((Dersler)cmbDersAdi.SelectedItem).DerslerId;
                notlartablo.Vize = Convert.ToInt32(txtVize.Text);
                NotlarTablo.NotGirisi(notlartablo);
                MessageBox.Show("Vize giriş işlemi başarılı");
            } 
            else
            {
                MessageBox.Show("Lütfen gerekli bilgileri giriniz");
            }
            
            Temizle();
        }

        private void DerslerDoldur()
        {
            OgrenciTablo ogrencitablo = new OgrenciTablo();
            ogrencitablo.OgrenciNo = txtOgrenciNo.Text;
            int ogrenciIdsi = OgrenciTablo.OgrenciIdBul(ogrencitablo);
            int OgretmenIdsi=OgretmenTablo.OgretmenIdBul2();

            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "SELECT Ahmet_Dersler.DerslerId,Ahmet_Dersler.DersAdi FROM Ahmet_Dersler INNER JOIN Ahmet_SecilenDersler ON Ahmet_Dersler.DerslerId = Ahmet_SecilenDersler.DerslerId where Ahmet_SecilenDersler.OgrenciId=@OgrenciId AND Ahmet_Dersler.OgretmenId=@OgretmenId  ";
            cmd.Parameters.AddWithValue("@OgrenciId", ogrenciIdsi);
            cmd.Parameters.AddWithValue("@OgretmenId", OgretmenIdsi);
            
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Bu öğrenciye not verme yetkiniz yoktur");
            }
            else
            {
                while (reader.Read())
                {
                    Dersler dersler = new Dersler();
                    {
                        dersler.DerslerId = reader.GetInt32(0);
                        dersler.DersAdi = reader.GetString(1);
                    }
                    cmbDersAdi.Items.Add(dersler);
                }
                cmbDersAdi.SelectedIndex = 0;
            }

            conn.Close();
            
        }

        private void NotGiris_Load(object sender, EventArgs e)
        {
            Temizle();
        }

        private void AdSoyadDoldur()
        {
            OgrenciTablo ogrencitablo = new OgrenciTablo();
            ogrencitablo.OgrenciNo = txtOgrenciNo.Text;
            int ogrenciIdsi = OgrenciTablo.OgrenciIdBul(ogrencitablo);
            
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT Ad,Soyad FROM Ahmet_Kisisel where Ahmet_Kisisel.OgrenciId=@OgrenciId";
            cmd.Parameters.AddWithValue("@OgrenciId",ogrenciIdsi) ;
            cmd.Connection = conn;
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Kisisel adsoyad = new Kisisel();
                {
                    adsoyad.Ad = reader.GetString(0);
                    adsoyad.Soyad = reader.GetString(1);
                }
                txtAdSoyad.Text=(adsoyad.Ad+" "+adsoyad.Soyad);
            }
            conn.Close();
            DerslerDoldur();

            
        }

        private void Kontrol()
        {
            OgrenciTablo ogrencitablo = new OgrenciTablo();
            ogrencitablo.OgrenciNo = txtOgrenciNo.Text;
            int ogrenciIdsi = OgrenciTablo.OgrenciIdBul(ogrencitablo);
            int secilendersid = ((Dersler)cmbDersAdi.SelectedItem).DerslerId;

            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "SELECT NotlarId,Vize FROM Ahmet_Notlar WHERE Ahmet_Notlar.OgrenciId=@OgrenciId AND Ahmet_Notlar.DerslerId=@DerslerId AND Ahmet_Notlar.Vize IS NOT NULL AND Ahmet_Notlar.Final IS NULL ";
            cmd.Parameters.AddWithValue("@OgrenciId", ogrenciIdsi);
            cmd.Parameters.AddWithValue("@DerslerId", secilendersid);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                            
                while (reader.Read())
                {
                    NotlarTablo notlar = new NotlarTablo();
                    {
                        notlar.NotlarId = reader.GetInt32(0);
                        notlar.Vize = reader.GetInt32(1);
                    }
                    txtVize.Text = Convert.ToString(notlar.Vize);
                    MessageBox.Show("Bu Öğrenciye daha önce vize için not verilmiştir.");
                }
            }
            reader.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT NotlarId,Vize,Final,Ortalama FROM Ahmet_Notlar WHERE Ahmet_Notlar.OgrenciId=@OgrenciId AND Ahmet_Notlar.DerslerId=@DerslerId AND Ahmet_Notlar.Vize IS NOT NULL AND Ahmet_Notlar.Final IS NOT NULL ";
            cmd.Parameters.AddWithValue("@OgrenciId", ogrenciIdsi);
            cmd.Parameters.AddWithValue("@DerslerId", secilendersid);
            SqlDataReader reader2 = cmd.ExecuteReader();
            if (reader2.HasRows)
            {
                
                while (reader2.Read())
                {
                    NotlarTablo notlar = new NotlarTablo();
                    {
                        notlar.NotlarId = reader2.GetInt32(0);
                        notlar.Vize = reader2.GetInt32(1);
                        notlar.Final = reader2.GetInt32(2);
                        notlar.Ortalama = reader2.GetInt32(3);
                    }
                    txtVize.Text = Convert.ToString(notlar.Vize);
                    txtVize.ReadOnly = true;
                    txtFinal.Text = Convert.ToString(notlar.Final);
                    txtOrtalama.Text = Convert.ToString(notlar.Ortalama);
                    MessageBox.Show("Bu Öğrenciye daha önce vize ve final notu verilmiştir. İsterseniz  FİNAL notunun güncellemesini yapabilirsiniz");
                }
            }
            
            conn.Close();      
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {   
            NotlarTablo notlartablo = new NotlarTablo();
            notlartablo.Vize = Convert.ToInt32(txtVize.Text);
            notlartablo.Final = Convert.ToInt32(txtFinal.Text);
            int ortalama = (Convert.ToInt32((notlartablo.Vize * 0.3) + (notlartablo.Final * 0.7)));
            txtOrtalama.Text = ortalama.ToString();
        }

        private void btnOgrenciBul_Click(object sender, EventArgs e)
        {
            AdSoyadDoldur();   
        }

        private void cmbDersAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVize.ReadOnly = false;
            txtVize.Text = "";
            txtFinal.Text = "";
            txtOrtalama.Text = "";

            Kontrol();
        }  
    }
}
