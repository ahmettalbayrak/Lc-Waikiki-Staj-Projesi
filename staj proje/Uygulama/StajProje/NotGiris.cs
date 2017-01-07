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

        //private void Temizle()
        //{
        //    txtVize.Text = "";
        //    txtFinal.Text = "";
        //    txtAdSoyad.Text = "";
        //    txtOrtalama.Text = "";
        //    txtOgrenciNo.Text = "";
        //    cmbDersAdi.Items.Clear();

        //}

        //private void btnKaydet_Click(object sender, EventArgs e)
        //{
        //    OgrenciTablo ogrencitablo = new OgrenciTablo();
        //    ogrencitablo.OgrenciNo = txtOgrenciNo.Text;

        //    NotlarTablo notlartablo = new NotlarTablo();
        //    notlartablo.Vize = Convert.ToInt32(txtVize.Text);
        //    notlartablo.Final = Convert.ToInt32(txtFinal.Text);
        //    notlartablo.Ortalama = Convert.ToInt32((notlartablo.Vize * 0.3) + (notlartablo.Final * 0.7));
        //    notlartablo.OgrenciId = OgrenciTablo.OgrenciIdBul(ogrencitablo);
        //    notlartablo.DerslerId = ((Dersler)cmbDersAdi.SelectedItem).DerslerId;
        //    NotlarTablo.NotGiris(notlartablo);
        //    MessageBox.Show("Not Girişi Başarılı");
        //    Temizle();
        //}

        private void DerslerDoldur()
        {
            OgrenciTablo ogrencitablo = new OgrenciTablo();
            ogrencitablo.OgrenciNo = txtOgrenciNo.Text;
            int ogrenciIdsi = OgrenciTablo.OgrenciIdBul(ogrencitablo);
            int OgretmenIdsi = OgretmenTablo.OgretmenIdBul2();
            DataTable tablo = new DataTable();
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "SELECT Ahmet_Dersler.DersAdi, Ahmet_Notlar.Vize, Ahmet_Notlar.Final, Ahmet_Notlar.Ortalama FROM Ahmet_Dersler INNER JOIN Ahmet_SecilenDersler ON Ahmet_Dersler.DerslerId = Ahmet_SecilenDersler.DerslerId INNER JOIN Ahmet_Notlar ON Ahmet_Dersler.DerslerId = Ahmet_Notlar.DerslerId WHERE Ahmet_SecilenDersler.OgrenciId=@OgrenciId AND Ahmet_Dersler.OgretmenId=@OgretmenId ";
            cmd.Parameters.AddWithValue("@OgrenciId", ogrenciIdsi);
            cmd.Parameters.AddWithValue("@OgretmenId", OgretmenIdsi);
            SqlDataReader reader = cmd.ExecuteReader();
            tablo.Load(reader);

            dgNotGiris.DataSource = tablo;
            dgNotGiris.Columns[1].HeaderText = "Ders Adı";
            dgNotGiris.Columns[2].HeaderText = "Vize";
            dgNotGiris.Columns[3].HeaderText = "Final";
            dgNotGiris.Columns[4].HeaderText = "Ortalama";

            
            
            
        }

        private void NotGiris_Load(object sender, EventArgs e)
        {
            //Temizle();
        }

        private void txtOgrenciNo_Click(object sender, EventArgs e)
        {
            DerslerDoldur();
        }

        
        //private void AdSoyadDoldur()
        //{
        //    OgrenciTablo ogrencitablo = new OgrenciTablo();
        //    ogrencitablo.OgrenciNo = txtOgrenciNo.Text;
        //    int ogrenciIdsi = OgrenciTablo.OgrenciIdBul(ogrencitablo);

        //    SqlConnection conn = DbConncection.GetSqlConnection();

        //    var cmd = new SqlCommand();

        //    cmd.CommandText = "SELECT Ad,Soyad FROM Ahmet_Kisisel where Ahmet_Kisisel.OgrenciId=@OgrenciId";
        //    cmd.Parameters.AddWithValue("@OgrenciId", ogrenciIdsi);

        //    cmd.Connection = conn;
        //    conn.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        Kisisel adsoyad = new Kisisel();
        //        {

        //            adsoyad.Ad = reader.GetString(0);
        //            adsoyad.Soyad = reader.GetString(1);
        //        }

        //        txtAdSoyad.Text = (adsoyad.Ad + " " + adsoyad.Soyad);
        //    }

        //    conn.Close();
        //    DerslerDoldur();
        //}

        //private void txtAdSoyad_Click(object sender, EventArgs e)
        //{
        //    AdSoyadDoldur();
        //}

        //private void txtOrtalama_Click(object sender, EventArgs e)
        //{
        //    NotlarTablo notlartablo = new NotlarTablo();
        //    notlartablo.Vize = Convert.ToInt32(txtVize.Text);
        //    notlartablo.Final = Convert.ToInt32(txtFinal.Text);
        //    int ortalama = (Convert.ToInt32((notlartablo.Vize * 0.3) + (notlartablo.Final * 0.7)));
        //    txtOrtalama.Text = ortalama.ToString();
        //}

        //private void cmbDersAdi_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    OgrenciTablo ogrencitablo = new OgrenciTablo();
        //    ogrencitablo.OgrenciNo = txtOgrenciNo.Text;
        //    int ogrenciIdsi = OgrenciTablo.OgrenciIdBul(ogrencitablo);
        //    int secilendersid = ((Dersler)cmbDersAdi.SelectedItem).DerslerId;

        //    SqlConnection conn = DbConncection.GetSqlConnection();

        //    var cmd = new SqlCommand();
        //    cmd.Connection = conn;
        //    conn.Open();
        //    cmd.CommandText = "SELECT Vize,Final,Ortalama FROM Ahmet_Notlar where Ahmet_Notlar.OgrenciId=@OgrenciId AND Ahmet_Notlar.DerslerId=@DerslerId ";
        //    cmd.Parameters.AddWithValue("@OgrenciId", ogrenciIdsi);
        //    cmd.Parameters.AddWithValue("@DerslerId", secilendersid);


        //    SqlDataReader reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        txtVize.Text = reader.GetString(0);
        //        txtFinal.Text = reader.GetString(1);
        //        txtOrtalama.Text = reader.GetString(2);
        //        MessageBox.Show("Bu Öğrenciye daha önce not verilmiştir");
        //    }

        //    conn.Close();

        //}
    }
}
