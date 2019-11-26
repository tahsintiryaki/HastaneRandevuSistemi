using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class RollerBLL
    {
        RollerDAL rollerDAL;
        public RollerBLL()
        {
            rollerDAL = new RollerDAL();
        }
        public List<Roller> RollerListele()
        {
            return rollerDAL.RolleriGoster();
        }
    }
}
