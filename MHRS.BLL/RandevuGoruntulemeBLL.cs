using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class RandevuGoruntulemeBLL
    {
        RandevuGoruntulemeDAL randevuGoruntulemeDAL;
        public RandevuGoruntulemeBLL()
        {
            randevuGoruntulemeDAL = new RandevuGoruntulemeDAL();
        }
        public List<RandevuGoruntuleme> RandevuGoruntulemeListele()
        {
            return randevuGoruntulemeDAL.GetAllRandevuGoruntuleme();
        }
        public List<RandevuGoruntuleme> RandevuGoruntulemeListeleID(int randevuID)
        {
            return randevuGoruntulemeDAL.GetByIDRandevuGoruntuleme(randevuID);
        }
        public bool Add(RandevuGoruntuleme randevu)
        {
            int result = randevuGoruntulemeDAL.RandevuAdd(randevu);
            return result > 0;
        }
    }
}
