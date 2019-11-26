using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class MuayeneBilgileriBLL
    {
        MuayeneBilgileriDAL muayeneBilgileriDAL;

        public MuayeneBilgileriBLL()
        {
            muayeneBilgileriDAL = new MuayeneBilgileriDAL();
        }
        public List<MuayeneBilgileri> MuayeneBilgileriListele()
        {
            return muayeneBilgileriDAL.GetAllMuayeneBilgileri();
        }
        public MuayeneBilgileri MuayeneBilgileriListeleID(int MuayeneID)
        {
            return muayeneBilgileriDAL.GetByIDMuayeneBilgileri(MuayeneID);
        }

        public bool Add(MuayeneBilgileri muayene)
        {
            int result = muayeneBilgileriDAL.MuayeneAdd(muayene);
            return result > 0;
        }

        public bool TeshisGuncelle (int hastaID, string teshis)
        {
            int result = muayeneBilgileriDAL.TeshisiGuncelle(hastaID, teshis);
            return result > 0;
        }
    }
}
