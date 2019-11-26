using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class SaatlerBLL
    {
        SaatlerDAL saatlerDAL;
        public SaatlerBLL()
        {
            saatlerDAL = new SaatlerDAL();
        }
        public List<Saatler> SaatlerListele()
        {
            return saatlerDAL.GetAllSaatler();
        }
        public List<Saatler> MusaitSaatleriListele()
        {
            return saatlerDAL.MusaitSaatleriGetir();
        }
        public  Saatler SaatlerListeleDurum(bool SaatDurum)
        {
            return saatlerDAL.GetByIDSaatler(SaatDurum);

        }

        public bool Update(Saatler saatler, bool durum)
        {
            if (durum == true)
            {
                saatler.SaatDurumu = true;
            }
            int result = saatlerDAL.UpdateSaatDurumu(saatler);
            return result > 0;
        }
    }
}
