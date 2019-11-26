using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class IllerBLL
    {
        IllerDAL illerDAL;
        public IllerBLL()
        {
            illerDAL = new IllerDAL();
        }
        public List<Iller> IllerListele()
        {
            return illerDAL.GetAllIller();
        }
    }
}
