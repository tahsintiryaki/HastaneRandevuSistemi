using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class BolumlerBLL
    {
        BolumlerDAL bolumlerDAL;
        public BolumlerBLL()
        {
            bolumlerDAL = new BolumlerDAL();
        }

        public List<Bolumler> BolumleriListele()
        {
            return bolumlerDAL.AllGetBolumler();
        }
        public Bolumler BolumleriListeleID(int bolumID)
        {
            return bolumlerDAL.GetByIDBolum(bolumID);
        }
    }
}
