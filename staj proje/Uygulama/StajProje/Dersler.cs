using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class Dersler
    {
        public int DerslerId { get; set; }
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public string KiminVerdigi { get; set; }
        public int Donem { get; set; }
        public int Sinif { get; set; }
        public int OgrenciId { get; set; }
        public int OgretmenId { get; set; }
        public int SecilenId { get; set; }

        public override string ToString()
        {
            return this.DersAdi;
        }
    }
}
