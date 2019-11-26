using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
  public class RecetelerBLL
    {
        RecetelerDAL recetelerDAL;

        public RecetelerBLL()
        {
            recetelerDAL = new RecetelerDAL();
        }

        public Receteler RecetelerListeleReceteKodu(int ReceteKodu)
        {
            return recetelerDAL.GetByCodeReceteler(ReceteKodu);
        }

        public List<Receteler> RecetelerListeleHastaID(int HastaID)
        {
            return recetelerDAL.GetByHastaIDReceteler(HastaID);
        }

        public bool Add(Receteler recete)
        {
            int result = recetelerDAL.ReceteEkle(recete);
            return result > 0;
        }
    }
}
