using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MHRS.Entities
{
   public class Receteler
    {
        public int ReceteID { get; set; }
        public int EzcaneID { get; set; }
        public int ReceteKodu { get; set; }
        public int HastaID { get; set; }
        public string Ilaclar { get; set; }
    }
}
