using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MHRS.Entities
{
   public class RandevuOlusturma
    {
        public int RandevuID { get; set; }
        public int HastaID { get; set; }
        public int IlID { get; set; }
        public int TeshisID { get; set; }
        public int SeansID { get; set; }
        public int MuayeneID { get; set; }
        public int RandevuGoruntulemeID { get; set; }
    }
}
