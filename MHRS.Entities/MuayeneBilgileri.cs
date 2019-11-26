using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MHRS.Entities
{
   public class MuayeneBilgileri
    {
        public int MuayeneID { get; set; }
        public int HastaID { get; set; }
        public string HastaAd { get; set; }
        public string TeshisAd { get; set; }
        public DateTime Tarih { get; set; }
        public TimeSpan Saat { get; set; }
        public string MuayeneDurumu { get; set; }
        public string Notlar { get; set; }
    }
}
