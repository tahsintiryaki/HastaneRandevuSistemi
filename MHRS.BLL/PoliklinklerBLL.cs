using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class PoliklinklerBLL
    {
        PoliklinklerDAL poliklinklerDAL;
        public PoliklinklerBLL()
        {
            poliklinklerDAL = new PoliklinklerDAL();
        }
        public List<Poliklinkler> PoliklinklerListele()
        {
            return poliklinklerDAL.GetAllPoliklinkler();
        }
        public Poliklinkler PoliklinklerListeleID(int PolId)
        {
            return poliklinklerDAL.GetByIDPoliklinkler(PolId);
        }
    }
}
