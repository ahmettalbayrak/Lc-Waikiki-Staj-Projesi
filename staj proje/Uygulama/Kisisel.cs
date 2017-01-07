using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class Kisisel
    {
        public int KisiselId { get; set; }
        public string TC { get; set; }
        public string Ad { get; set; }
        public override string ToString()
        {
            return this.Ad + ' ' + this.Soyad;
        }
        public string Soyad { get; set; }
        public DateTime DogumTarih { get; set;}
        public string Mail { get; set; }
        public string EvTel { get; set; }
        public string CepTel { get; set; }
        public string Unvan { get; set; }
        public int CinsiyetId { get; set; }
        public int MedeniDurumId { get; set; }
        public int KullaniciTipiId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int OgrenciId { get; set; }
        public int OgretmenId { get; set; }
        public int MemurId { get; set; }
        public int VeliId{ get; set; }

        public static bool KisiselEkle(Kisisel yeniOgrenciKisisel)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Ahmet_Kisisel(TC,Ad,Soyad,DogumTarih,CinsiyetId,MedeniDurumId,Mail,EvTel,CepTel,Unvan,KullaniciTipiId,OgrenciId,KullaniciAdi,Sifre) VALUES(@TC, @Ad, @Soyad, @DogumTarih, @CinsiyetId, @MedeniDurumId, @Mail, @EvTel, @CepTel,@Unvan,@KullaniciTipiId,@OgrenciId,@KullaniciAdi,@Sifre)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@TC", yeniOgrenciKisisel.TC);
            cmd.Parameters.AddWithValue("@Ad", yeniOgrenciKisisel.Ad);
            cmd.Parameters.AddWithValue("@Soyad", yeniOgrenciKisisel.Soyad);
            cmd.Parameters.AddWithValue("@DogumTarih", yeniOgrenciKisisel.DogumTarih);
            cmd.Parameters.AddWithValue("@CinsiyetId", yeniOgrenciKisisel.CinsiyetId);
            cmd.Parameters.AddWithValue("@MedeniDurumId", yeniOgrenciKisisel.MedeniDurumId);
            cmd.Parameters.AddWithValue("@Mail", yeniOgrenciKisisel.Mail);
            cmd.Parameters.AddWithValue("@EvTel", yeniOgrenciKisisel.EvTel);
            cmd.Parameters.AddWithValue("@CepTel", yeniOgrenciKisisel.CepTel);
            cmd.Parameters.AddWithValue("@Unvan", yeniOgrenciKisisel.Unvan);
            cmd.Parameters.AddWithValue("@KullaniciTipiId", yeniOgrenciKisisel.KullaniciTipiId);
            cmd.Parameters.AddWithValue("@OgrenciId", yeniOgrenciKisisel.OgrenciId);
            cmd.Parameters.AddWithValue("@KullaniciAdi", yeniOgrenciKisisel.KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", yeniOgrenciKisisel.Sifre);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }

        public static bool KisiselOgrenciEkle(Kisisel yeniOgrenciKisisel)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Ahmet_Kisisel(TC,Ad,Soyad,DogumTarih,CinsiyetId,MedeniDurumId,Mail,EvTel,CepTel,Unvan,KullaniciTipiId,OgrenciId,KullaniciAdi,Sifre) VALUES(@TC, @Ad, @Soyad, @DogumTarih, @CinsiyetId, @MedeniDurumId, @Mail, @EvTel, @CepTel,@Unvan,@KullaniciTipiId,@OgrenciId,@KullaniciAdi,@Sifre)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@TC", yeniOgrenciKisisel.TC);
            cmd.Parameters.AddWithValue("@Ad", yeniOgrenciKisisel.Ad);
            cmd.Parameters.AddWithValue("@Soyad", yeniOgrenciKisisel.Soyad);
            cmd.Parameters.AddWithValue("@DogumTarih", yeniOgrenciKisisel.DogumTarih);
            cmd.Parameters.AddWithValue("@CinsiyetId", yeniOgrenciKisisel.CinsiyetId);
            cmd.Parameters.AddWithValue("@MedeniDurumId", yeniOgrenciKisisel.MedeniDurumId);
            cmd.Parameters.AddWithValue("@Mail", yeniOgrenciKisisel.Mail);
            cmd.Parameters.AddWithValue("@EvTel", yeniOgrenciKisisel.EvTel);
            cmd.Parameters.AddWithValue("@CepTel", yeniOgrenciKisisel.CepTel);
            cmd.Parameters.AddWithValue("@Unvan", yeniOgrenciKisisel.Unvan);
            cmd.Parameters.AddWithValue("@KullaniciTipiId", yeniOgrenciKisisel.KullaniciTipiId);
            cmd.Parameters.AddWithValue("@OgrenciId", yeniOgrenciKisisel.OgrenciId);
            cmd.Parameters.AddWithValue("@KullaniciAdi", yeniOgrenciKisisel.KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", yeniOgrenciKisisel.Sifre);
            
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }

        public static bool KisiselOgretmenEkle(Kisisel yeniOgretmenKisisel)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Ahmet_Kisisel(TC,Ad,Soyad,DogumTarih,CinsiyetId,MedeniDurumId,Mail,EvTel,CepTel,Unvan,KullaniciTipiId,OgretmenId,KullaniciAdi,Sifre) VALUES(@TC, @Ad, @Soyad, @DogumTarih, @CinsiyetId, @MedeniDurumId, @Mail, @EvTel, @CepTel,@Unvan,@KullaniciTipiId,@OgretmenId,@KullaniciAdi,@Sifre)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@TC", yeniOgretmenKisisel.TC);
            cmd.Parameters.AddWithValue("@Ad", yeniOgretmenKisisel.Ad);
            cmd.Parameters.AddWithValue("@Soyad", yeniOgretmenKisisel.Soyad);
            cmd.Parameters.AddWithValue("@DogumTarih", yeniOgretmenKisisel.DogumTarih);
            cmd.Parameters.AddWithValue("@CinsiyetId", yeniOgretmenKisisel.CinsiyetId);
            cmd.Parameters.AddWithValue("@MedeniDurumId", yeniOgretmenKisisel.MedeniDurumId);
            cmd.Parameters.AddWithValue("@Mail", yeniOgretmenKisisel.Mail);
            cmd.Parameters.AddWithValue("@EvTel", yeniOgretmenKisisel.EvTel);
            cmd.Parameters.AddWithValue("@CepTel", yeniOgretmenKisisel.CepTel);
            cmd.Parameters.AddWithValue("@Unvan", yeniOgretmenKisisel.Unvan);
            cmd.Parameters.AddWithValue("@KullaniciTipiId", yeniOgretmenKisisel.KullaniciTipiId);
            cmd.Parameters.AddWithValue("@OgretmenId", yeniOgretmenKisisel.OgretmenId);
            cmd.Parameters.AddWithValue("@KullaniciAdi", yeniOgretmenKisisel.KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", yeniOgretmenKisisel.Sifre);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }

        public static bool KisiselVeliEkle(Kisisel yeniVeliKisisel)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Ahmet_Kisisel(TC,Ad,Soyad,DogumTarih,CinsiyetId,MedeniDurumId,Mail,EvTel,CepTel,Unvan,KullaniciTipiId,VeliId,KullaniciAdi,Sifre) VALUES(@TC, @Ad, @Soyad, @DogumTarih, @CinsiyetId, @MedeniDurumId, @Mail, @EvTel, @CepTel,@Unvan,@KullaniciTipiId,@VeliId,@KullaniciAdi,@Sifre)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@TC", yeniVeliKisisel.TC);
            cmd.Parameters.AddWithValue("@Ad", yeniVeliKisisel.Ad);
            cmd.Parameters.AddWithValue("@Soyad", yeniVeliKisisel.Soyad);
            cmd.Parameters.AddWithValue("@DogumTarih", yeniVeliKisisel.DogumTarih);
            cmd.Parameters.AddWithValue("@CinsiyetId", yeniVeliKisisel.CinsiyetId);
            cmd.Parameters.AddWithValue("@MedeniDurumId", yeniVeliKisisel.MedeniDurumId);
            cmd.Parameters.AddWithValue("@Mail", yeniVeliKisisel.Mail);
            cmd.Parameters.AddWithValue("@EvTel", yeniVeliKisisel.EvTel);
            cmd.Parameters.AddWithValue("@CepTel", yeniVeliKisisel.CepTel);
            cmd.Parameters.AddWithValue("@Unvan", yeniVeliKisisel.Unvan);
            cmd.Parameters.AddWithValue("@KullaniciTipiId", yeniVeliKisisel.KullaniciTipiId);
            cmd.Parameters.AddWithValue("@VeliId", yeniVeliKisisel.VeliId);
            cmd.Parameters.AddWithValue("@KullaniciAdi", yeniVeliKisisel.KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", yeniVeliKisisel.Sifre);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }

        public static bool KisiselMemurEkle(Kisisel yeniVeliOgretmenKisisel)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Ahmet_Kisisel(TC,Ad,Soyad,DogumTarih,CinsiyetId,MedeniDurumId,Mail,EvTel,CepTel,Unvan,KullaniciTipiId,MemurId,KullaniciAdi,Sifre) VALUES(@TC, @Ad, @Soyad, @DogumTarih, @CinsiyetId, @MedeniDurumId, @Mail, @EvTel, @CepTel,@Unvan,@KullaniciTipiId,@MemurId,@KullaniciAdi,@Sifre)";
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@TC", yeniVeliOgretmenKisisel.TC);
            cmd.Parameters.AddWithValue("@Ad", yeniVeliOgretmenKisisel.Ad);
            cmd.Parameters.AddWithValue("@Soyad", yeniVeliOgretmenKisisel.Soyad);
            cmd.Parameters.AddWithValue("@DogumTarih", yeniVeliOgretmenKisisel.DogumTarih);
            cmd.Parameters.AddWithValue("@CinsiyetId", yeniVeliOgretmenKisisel.CinsiyetId);
            cmd.Parameters.AddWithValue("@MedeniDurumId", yeniVeliOgretmenKisisel.MedeniDurumId);
            cmd.Parameters.AddWithValue("@Mail", yeniVeliOgretmenKisisel.Mail);
            cmd.Parameters.AddWithValue("@EvTel", yeniVeliOgretmenKisisel.EvTel);
            cmd.Parameters.AddWithValue("@CepTel", yeniVeliOgretmenKisisel.CepTel);
            cmd.Parameters.AddWithValue("@Unvan", yeniVeliOgretmenKisisel.Unvan);
            cmd.Parameters.AddWithValue("@KullaniciTipiId", yeniVeliOgretmenKisisel.KullaniciTipiId);
            cmd.Parameters.AddWithValue("@MemurId", yeniVeliOgretmenKisisel.MemurId);
            cmd.Parameters.AddWithValue("@KullaniciAdi", yeniVeliOgretmenKisisel.KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", yeniVeliOgretmenKisisel.Sifre);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
            conn.Close();
        }

        public static int KullaniciSorgula(string kullaniciAdi, string sifre, int kullaniciTipId)
        {
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "select KullaniciTipiId from Ahmet_Kisisel where KullaniciAdi=@kullaniciadi and Sifre=@sifre and KullaniciTipiId=@kullanicitipid  ";
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            cmd.Parameters.AddWithValue("@kullanicitipid", kullaniciTipId);

            conn.Open();

            int sorgusonuc = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return sorgusonuc;
        }
        }
}
