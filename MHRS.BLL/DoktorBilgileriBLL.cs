using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class DoktorBilgileriBLL
    {
        DoktorBilgileriDAL doktorBilgileriDAL;
        public DoktorBilgileriBLL()
        {
            doktorBilgileriDAL = new DoktorBilgileriDAL();
        }
        public List<DoktorBilgileri> DoktorBilgileriListele()
        {
            return doktorBilgileriDAL.AllGetDoktorBilgileri();
        }
        public DoktorBilgileri DoktorBilgileriListeleID(int DoktorID)
        {
            return doktorBilgileriDAL.GetByIdDoktorBilgileri(DoktorID);
        }
    }
}
