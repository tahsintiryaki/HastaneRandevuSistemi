using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
   public class HastaBilgileriBLL
    {
        HastaBilgileriDAL hastaBilgileriDAL;
        UyeGirisDAL uyeGirisDAL;

        public HastaBilgileriBLL()
        {
            hastaBilgileriDAL = new HastaBilgileriDAL();
            uyeGirisDAL = new UyeGirisDAL();
        }

        public  List<HastaBilgileri> HastaBilgileriListele()
        {
            return hastaBilgileriDAL.GetAllHastaBilgileri();
        }
        public HastaBilgileri HastaBilgileriListeleID(int HastaID)
        {
            return hastaBilgileriDAL.GetByIDHastaBilgileri(HastaID);
        }
        public bool HastaEkle(HastaBilgileri hasta)
        {
            UyeOlKontrol(hasta.Tc_No, hasta.Ad, hasta.Soyad, hasta.Email, hasta.Parola);
            int result = hastaBilgileriDAL.AddHastaBilgileri(hasta);
            return result > 0;
        }
        public bool HastaUyeTabloEkle(UyeGiris uye)
        {
            GirisKontrol(uye.Email,uye.Parola,uye.RolID);
            int result = uyeGirisDAL.HastaAdd(uye);
            return result > 0;
        }

        //UyeGiriş ve UyeOlma Kontrolleri
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
            //alanlar adı null olamaz
            if (string.IsNullOrEmpty(mail) && string.IsNullOrEmpty(pass))
            {
                throw new TextBoxBosKontrolu();
            }

        }
        public void TumAlanlarBosBirakilamazKonrolu(string tc, string ad, string soyad, string email, string sifre)
        {
            //E-Mail sifre dışındakiler için tüm alanlar null olamaz kontrolü;
            if (tc.Length < 11 && string.IsNullOrEmpty(ad) && string.IsNullOrEmpty(soyad) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(sifre))
            {
                throw new TextBoxBosKontrolu();
            }

        }
        public void HastaTcNoKontrol(string TcNo)
        {
            
            if (TcNo.Length<11)
            {
                throw new TcNoKontrol();
            }
        }
        public void GirisKontrol(string mail, string pass,int rolID)
        {
            int sayac = 0;
            CheckEmailString(mail);
            SifreKontrol(pass);
            BosBirakilamazKontrolu(mail, pass);
            List<UyeGiris> uyeler = uyeGirisDAL.UyeGirisiGoruntule();
            foreach (var item in uyeler)
            {
                if (item.Email == mail && item.Parola == pass && item.RolID == rolID)
                {

                    sayac++;
                    break;
                }


                //else if (item.Email == mail && item.Parola == pass && item.RolID == rolID)
                //{
                //    if (rolID == 2)
                //    {
                //        break;
                //    }
                //    else if (rolID == 3)
                //    {
                //        break;
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}
            }

            if (sayac == 0)
            {
                throw new KullaniciKayitliDegilKontrol();
            }
        }
        public void UyeOlKontrol(string tc, string ad, string soyad,string mail,string pass)
        {
            CheckEmailString(mail);
            SifreKontrol(pass);
            HastaTcNoKontrol(tc);
            TumAlanlarBosBirakilamazKonrolu(tc, ad, soyad, mail, pass);
            List<HastaBilgileri> hastalar = hastaBilgileriDAL.GetAllHastaBilgileri();
            foreach (var item in hastalar)
            {
                if (item.Tc_No==tc)
                {
                    throw new KulaniciKontrol();
                }
            }
        }

        //YENİ EKLENDİ
        public HastaBilgileri HastaIdGetir(string email, string sifre)
        {
            return hastaBilgileriDAL.HastaIDGetir(email,sifre);
        }


    }
}
