using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MHRS.Entities
{
   public class RandevuGoruntuleme
    {
        public int RandevuGoruntulemeID { get; set; }
        public int HastaID { get; set; }
        public string HastaAd { get; set; }
        public string BolumAd { get; set; }
        public DateTime Tarih { get; set; }
        public TimeSpan Saat { get; set; }
    }
}
