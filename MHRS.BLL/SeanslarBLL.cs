using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class SeanslarBLL
    {
        SeanslarDAL seanslarDAL;
        public SeanslarBLL()
        {
            seanslarDAL = new SeanslarDAL();
        }
        public List<Seansler> SeanslerListele()
        {
            return seanslarDAL.GetAllSeansler();
        }
    }
}
