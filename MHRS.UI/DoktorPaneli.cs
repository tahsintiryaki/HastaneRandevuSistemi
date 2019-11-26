using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHRS.Entities;
using MHRS.BLL;

namespace MHRS.UI
{
    public partial class DoktorPaneli : Form
    {
        SeanslarBLL seanslarBLL;
        SaatlerBLL saatlerBLL;
        TeshislerBLL teshislerBLL;
        MuayeneBilgileriBLL muayeneBilgileriBLL;
        MuayeneBilgileri muayeneBilgileri;
        RecetelerBLL recetelerBLL;
        Receteler _receteler;

       

        public DoktorPaneli()
        {
            InitializeComponent();
            seanslarBLL = new SeanslarBLL();
            saatlerBLL = new SaatlerBLL();
            teshislerBLL = new TeshislerBLL();
            muayeneBilgileriBLL = new MuayeneBilgileriBLL();
            recetelerBLL = new RecetelerBLL();
        }

        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            cmbSeansSaatListe();
            cmbTeshisleriGetir();
            MuayaneleriListvieweGetir();

            this.Height = 370; //Arayüze dair ufak tefek çakallıklar-Part1
        }
        private void lstDoktorRandevulari_DoubleClick(object sender, EventArgs e)
        {
            this.Height = 716; //Arayüze dair ufak tefek çakallıklar-Part2
        }

        private void lstDoktorRandevulari_Click(object sender, EventArgs e)
        {
            this.Height = 370; //Arayüze dair ufak tefek çakallıklar-Part3
        }

        //Teşhis ekleme
        private void btnTeshisKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                muayeneBilgileri = new MuayeneBilgileri();
                if (monthCalendar1.SelectionRange.Start > DateTime.Now)
                {
                    muayeneBilgileri.Tarih = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString());
                }
                else
                {
                    MessageBox.Show("Geçmiş tarih den randevu alamazsınız!");
                }
                muayeneBilgileri.Saat = TimeSpan.Parse(cmbSeanslar.SelectedItem.ToString());
                muayeneBilgileri.MuayeneDurumu = "Muayene Edildi";
                muayeneBilgileri.HastaID = int.Parse(lstDoktorRandevulari.SelectedItems[0].SubItems[3].Text);
                muayeneBilgileri.TeshisAd = cmbTeshis.SelectedItem.ToString();
                muayeneBilgileri.MuayeneDurumu = "Muayene Edildi.";
                muayeneBilgileriBLL.TeshisGuncelle(muayeneBilgileri.HastaID,muayeneBilgileri.TeshisAd);
                MessageBox.Show("Teşhis Eklendi");
                muayeneBilgileri.Notlar = "deneme";
                muayeneBilgileriBLL.Add(muayeneBilgileri);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MuayaneleriListvieweGetir();
        }

        //Reçete ekleme, doktor zaten bu ekranı görmüyor sadece ekliyor, eczacı görecek.
        private void btnReceteKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _receteler = new Receteler();
                _receteler.HastaID = int.Parse(lstDoktorRandevulari.SelectedItems[0].SubItems[3].Text);
                _receteler.ReceteKodu = int.Parse(txtReceteKodu.Text);
                _receteler.Ilaclar = TxtIlaclar.Text;
                recetelerBLL.Add(_receteler);
                MessageBox.Show("Reçete Eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MuayaneleriListvieweGetir();
        }

        //Seansları comboBoxa getirme metodu;
        private void cmbSeansSaatListe()
        {
            List<Saatler> saatler = saatlerBLL.MusaitSaatleriListele();
            foreach (var item in saatler)
            {
                cmbSeanslar.Items.Add(item.Saat.ToString());
            }
           
        }

        //Teşhisleri comboBoxa getirme metodu;
        private void cmbTeshisleriGetir()
        {
            List<Teshisler> teshis = teshislerBLL.TeshislerListele();
            foreach (var item in teshis)
            {
                cmbTeshis.Items.Add(item.TeshisAd.ToString());
            }
        }

        //ListView'i doldurma
        private void MuayaneleriListvieweGetir()
        {
            lstDoktorRandevulari.Items.Clear();
            List<MuayeneBilgileri> muayeneler = muayeneBilgileriBLL.MuayeneBilgileriListele();
            foreach (var item in muayeneler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.MuayeneID.ToString();
                lvi.SubItems.Add(item.Tarih.ToShortDateString());
                lvi.SubItems.Add(item.Saat.ToString());
                lvi.SubItems.Add(item.HastaID.ToString());
                lvi.SubItems.Add(item.MuayeneDurumu);
                lvi.SubItems.Add(item.TeshisAd);
                lvi.SubItems.Add(item.Notlar);
                lstDoktorRandevulari.Items.Add(lvi);

            }
        }

        private void LstDoktorRandevulari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            string value = "";
            Random rnd = new Random();
            for (int c = 0; c < 5; c++)
            {
                int ck = rnd.Next(0, 2);
                if (ck == 0)
                {
                    int num = rnd.Next(1, 10);
                    value += num.ToString();
                }
                else
                {
                    int x = rnd.Next(65, 91);
                    char chr = Convert.ToChar(x);
                    value += chr;
                }
            }
            txtReceteKodu.Text = value;
        }
    }
}
