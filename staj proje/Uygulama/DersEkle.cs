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
    public partial class DersEkle : Form
    {
        Fakulte secilen;

        public DersEkle()
        {
            InitializeComponent();
        }

        //private void FakulteDoldur()//2 tane
        //{
        //    SqlConnection conn = DbConncection.GetSqlConnection();
        //    var cmd = new SqlCommand();
        //    cmd.CommandText = "SELECT FakulteId,Fakulte FROM Ahmet_Fakulte";
        //    cmd.Connection = conn;
        //    conn.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Fakulte fakulte = new Fakulte();
        //        {
        //            fakulte.FakulteId = reader.GetInt32(0);
        //            fakulte.Fakultee = reader.GetString(1);
        //        }
        //        cmbFakulte.Items.Add(fakulte);
        //    }
        //    conn.Close();
        //}

        //private void BolumDoldur()//2 tane
        //{
        //    SqlConnection conn = DbConncection.GetSqlConnection();
        //    Fakulte secilen = (Fakulte)cmbFakulte.SelectedItem;
        //    var cmd = new SqlCommand();
        //    cmd.CommandText = "SELECT * FROM Ahmet_Bolum WHERE FakulteId=@fakulteId ";
        //    cmd.Parameters.AddWithValue("@fakulteId", secilen.FakulteId);
        //    cmd.Connection = conn;
        //    conn.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Bolum bolum = new Bolum();
        //        {
        //            bolum.BolumId = reader.GetInt32(0);
        //            bolum.Bolumm = reader.GetString(1);
        //        }

        //        cmbBolum.Items.Add(bolum);
        //    }

        //    conn.Close();
        //}

        private void SinifiDoldur()
        {
            for (int i = 1; i < 5; i++)
            {
                cmbSinif.Items.Add(i);
            }
        }

        private void DonemDoldur()
        {
            for (int i = 1; i < 3; i++)
            {


                cmbDonem.Items.Add(i);
            }
        }

        private void OgretmenDoldur()
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT OgretmenId,Ad,Soyad FROM Ahmet_Kisisel WHERE Ahmet_Kisisel.OgretmenId Is Not Null";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Kisisel kisisel = new Kisisel();
                {
                    kisisel.OgretmenId = reader.GetInt32(0);
                    kisisel.Ad = reader.GetString(1);
                    kisisel.Soyad = reader.GetString(2);
                }
                cmbOgretmen.Items.Add(kisisel);
            }
            conn.Close();
        }

        private void DersEkle_Load(object sender, EventArgs e)
        {
            
            List<Fakulte> fakulteler = Fakulte.FakulteDoldur();

            cmbFakulte.DisplayMember = "Fakulte";
            cmbFakulte.ValueMember = "FakulteId";
            cmbFakulte.DataSource = fakulteler;

            SinifiDoldur();
            DonemDoldur();
            OgretmenDoldur();
            cmbSinif.SelectedIndex = 0;
            cmbDonem.SelectedIndex = 0;
            cmbOgretmen.SelectedIndex = 0;
            cmbFakulte.SelectedIndex = 0;
            cmbBolum.SelectedIndex = 0;

        }

        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = (Fakulte)cmbFakulte.SelectedItem;
            List<Bolum> bolumler = Bolum.BolumDoldur(secilen.FakulteId);
            cmbBolum.DisplayMember = "Bolum";
            cmbBolum.ValueMember = "BolumId";
            cmbBolum.DataSource = bolumler;
            //cmbBolum.Items.Clear();
            ////BolumDoldur();
            //Fakulte secilen = (Fakulte)cmbFakulte.SelectedItem;
            //List<Bolum> bolumler = Bolum.BolumDoldur(secilen);

            //cmbBolum.DisplayMember = "Bolum";
            //cmbBolum.ValueMember = "BolumId";
            //cmbBolum.DataSource = bolumler;

            //cmbBolum.SelectedIndex = 0;
            
        }

        private void DersEkleme()
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Ahmet_Dersler (DersKodu,DersAdi,Sinif,Donem,OgretmenId,FakulteId,BolumId) VALUES(@DersKodu,@DersAdi,@Sinif,@Donem,@OgretmenId,@FakulteId,@BolumId)";
            cmd.Connection = conn;
            
            cmd.Parameters.AddWithValue("@DersKodu",txtDersKodu.Text);
            cmd.Parameters.AddWithValue("@DersAdi", txtDersAdi.Text);
            cmd.Parameters.AddWithValue("@Sinif", cmbSinif.SelectedItem);
            cmd.Parameters.AddWithValue("@Donem", cmbDonem.SelectedItem);
            cmd.Parameters.AddWithValue("@OgretmenId", ((Kisisel)cmbOgretmen.SelectedItem).OgretmenId);
            cmd.Parameters.AddWithValue("@FakulteId", ((Fakulte)cmbFakulte.SelectedItem).FakulteId);
            cmd.Parameters.AddWithValue("@BolumId", ((Bolum)cmbBolum.SelectedItem).BolumId);
            
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DersEkleme();
            MessageBox.Show("Ders Başarıyla Eklenmiştir");
            Temizle();
        }

        private void Temizle()
        {
            txtDersKodu.Text = "";
            txtDersAdi.Text = "";
            cmbSinif.SelectedIndex = 0;
            cmbDonem.SelectedIndex = 0;
            cmbOgretmen.SelectedIndex = 0;
            cmbFakulte.SelectedIndex = 0;
            cmbBolum.SelectedIndex = 0;   
        }
    }
}
