using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class TeshislerBLL
    {
        TeshislerDAL teshislerDAL;
        public TeshislerBLL()
        {
            teshislerDAL = new TeshislerDAL();
        }
        public List<Teshisler> TeshislerListele()
        {
            return teshislerDAL.GetAllTeshisler();
        }
       
    }
}
