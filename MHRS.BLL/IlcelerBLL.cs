using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class IlcelerBLL
    {
        IlcelerDAL ilcelerDAL;
        public IlcelerBLL()
        {
            ilcelerDAL = new IlcelerDAL();
        }
        public List<Ilceler> IlcelerListele()
        {
            return ilcelerDAL.GetAllIlceler();
        }
        public List<Ilceler> IlcelerListeleID(int ilceID)
        {
            return ilcelerDAL.GetByIDIlceler(ilceID);
        }
    }
}
