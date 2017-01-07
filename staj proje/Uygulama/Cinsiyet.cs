using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StajProje
{
    class Cinsiyet
    {
        public int CinsiyetId { get; set; }
        public string Cinsiyeti { get; set; }

        public override string ToString()
        {
            return this.Cinsiyeti;
        }   
    }
}
