using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class HastanelerBLL
    {
        HastanelerDAL hastanelerDAL;
        public HastanelerBLL()
        {
            hastanelerDAL = new HastanelerDAL();
        }
        public List<Hastaneler> HastanelerListele()
        {
            return hastanelerDAL.GetAllHastaneler();
        }
        public List<Hastaneler> HastanelerListelemeID(int HastaneID)
        {
            return hastanelerDAL.GetByIDHastaneler(HastaneID);
        }
    }
}
