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
    }
}

