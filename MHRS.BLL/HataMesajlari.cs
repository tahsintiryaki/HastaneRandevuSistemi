using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.BLL
{

    public class KulaniciKontrol : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu kullanıcı sistemde mevcut";
            }
        }
    }

    public class KullaniciKayitliDegilKontrol : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu kullanıcı sistemde mevcut degil";
            }
        }
    }

    public class EmailKontrol : Exception
    {
        public override string Message
        {
            get
            {
                return "Dogru bir Mail Adresi giriniz!";
            }
        }
    }

    public class SifreUzunlukKontrol : Exception
    {
        public override string Message
        {
            get
            {
                return "Sifreniz harf ve sayilarla min 8 ile max 16 karakter olmalı ";
            }
        }
    }

    public class SifreKarakterKontrol : Exception
    {
        public override string Message
        {
            get
            {
                return "Sifreniz özel karakter içermemelidir.";
            }
        }
    }

    public class TextBoxBosKontrolu : Exception
    {
        public override string Message
        {
            get
            {
                return "Alanlar boş geçilemez.";
            }
        }
    }

    public class TcNoKontrol : Exception
    {
        public override string Message
        {
            get
            {
                return "Tc No 11 haneden küçük olamaz!";
            }
        }
    }

}