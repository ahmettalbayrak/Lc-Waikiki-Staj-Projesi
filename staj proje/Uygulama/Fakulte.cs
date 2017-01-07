using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class Fakulte
    {
        public int FakulteId { get; set; }
        public string Fakultee { get; set; }
        public int OgrenciId { get; set; }
        public override string ToString()
        {
            return this.Fakultee;
        }

        public static List<Fakulte> FakulteDoldur()
        {
            //cmbFakulte.ValueMember = "FakulteId";
            //cmbFakulte.DisplayMember = "Fakultee";
            SqlConnection conn = DbConncection.GetSqlConnection();
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT FakulteId,Fakulte FROM Ahmet_Fakulte";
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Fakulte> fakulteler = new List<Fakulte>();
            while (reader.Read())
            {
                Fakulte fakulte = new Fakulte();
                {
                    fakulte.FakulteId = reader.GetInt32(0);
                    fakulte.Fakultee = reader.GetString(1);
                    fakulteler.Add(fakulte);
                }   
            }
            conn.Close();
            return fakulteler;
        }
    }
}

