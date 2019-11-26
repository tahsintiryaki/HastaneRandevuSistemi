using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MHRS.Entities
{
   public class Saatler
    {
        public int SaatID { get; set; }
        public TimeSpan Saat { get; set; }
        public bool SaatDurumu { get; set; }
    }
}
