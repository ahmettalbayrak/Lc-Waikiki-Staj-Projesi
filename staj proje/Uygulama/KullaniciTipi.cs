using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class KullaniciTipi
    {
        public int KullaniciTipiId { get; set; }

        public string Aciklama { get; set; }

        public override string ToString()
        {
            return this.Aciklama;
        }
    }
}
