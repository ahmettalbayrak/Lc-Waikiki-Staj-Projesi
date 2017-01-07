using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class MedeniDurum
    {
        public int MedeniDurumId { get; set; }
        public string MedeniDurumu { get; set; }

        public override string ToString()
        {
            return this.MedeniDurumu;
        }


    }
}
