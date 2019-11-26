using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class EzcaneBilgileriBLL
    {
        EzcaneBilgileriDAL ezcaneBilgileriDAL;
        public EzcaneBilgileriBLL()
        {
            ezcaneBilgileriDAL = new EzcaneBilgileriDAL();
        }
        public List<EzcaneBilgileri> EzcaneBilgileriListele()
        {
            return ezcaneBilgileriDAL.GetAllEzcaneBilgileri();
        }
    }
}
