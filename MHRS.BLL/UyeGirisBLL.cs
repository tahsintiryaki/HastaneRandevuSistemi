using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class UyeGirisBLL
    {
        UyeGirisDAL uyeGirisDAL;

        public UyeGirisBLL()
        {
            uyeGirisDAL = new UyeGirisDAL();
        }

        public bool Add(UyeGiris uye)
        {
            UyeOlKontrol(uye.Email, uye.Parola);
            int result = uyeGirisDAL.HastaAdd(uye);
            return result > 0;
        }

        public bool CheckEmailString(string mail)
        {
            if (mail.Contains("@"))
            {
                if (mail.Contains(".com"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new EmailKontrol();
            }
        }

        public bool SifreKontrol(string pass)
        {
            if (pass.Length >= 8 && pass.Length < 16)
            {
                Regex r = new Regex(pass);
                if (r.IsMatch(pass))
                {
                    return true;
                }
                else
                {
                    throw new SifreKarakterKontrol();
                }
            }
            else
            {
                throw new SifreUzunlukKontrol();
            }
        }

        public void BosBirakilamazKontrolu(string mail, string pass)
        {
            //alanlar null olamaz
            if (string.IsNullOrEmpty(mail) && string.IsNullOrEmpty(pass))
            {
                throw new TextBoxBosKontrolu();
            }

        }

        public void UyeOlKontrol( string mail, string pass)
        {
            CheckEmailString(mail);
            SifreKontrol(pass);

            List<UyeGiris> uyeler = uyeGirisDAL.UyeGirisiGoruntule();
            foreach (var item in uyeler)
            {
                if (item.Email == mail && item.Parola== pass)
                {
                    throw new KulaniciKontrol();
                }
            }
        }

    }
}
