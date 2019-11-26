using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHRS.BLL;
using MHRS.Entities;

namespace MHRS
{
    public partial class RandevuAlma : Form
    {
        IllerBLL illerBLL;
        IlcelerBLL ilcelerBLL;
        HastanelerBLL hastanelerBLL;
        PoliklinklerBLL poliklinklerBLL;
        BolumlerBLL bolumlerBLL;
        DoktorBilgileriBLL doktorBilgileriBLL;
        SeanslarBLL seanslarBLL;
        SaatlerBLL saatlerBLL;
        RandevuGoruntulemeBLL randevuGoruntulemeBLL;
        RandevuGoruntuleme randevuGoruntuleme;
       // HastaBilgileri hasta;    


        public RandevuAlma()
        {
            InitializeComponent();
            illerBLL = new IllerBLL();
            ilcelerBLL = new IlcelerBLL();
            hastanelerBLL = new HastanelerBLL();
            poliklinklerBLL = new PoliklinklerBLL();
            bolumlerBLL = new BolumlerBLL();
            doktorBilgileriBLL = new DoktorBilgileriBLL();
            seanslarBLL = new SeanslarBLL();
            saatlerBLL = new SaatlerBLL();
            randevuGoruntulemeBLL = new RandevuGoruntulemeBLL();
        }
        
        private void cmbIlListe()
        {
            List<Iller> iller = illerBLL.IllerListele();
            foreach (var item in iller)
            {
                cmbCity.Items.Add(item.IlAd);
            }
        }
        private void cmbIlceListe()
        {
            cmbDistrict.Items.Clear();
            List<Ilceler> ilce = ilcelerBLL.IlcelerListeleID(cmbCity.SelectedIndex + 1);
            foreach (var item in ilce)
            {
                cmbDistrict.Items.Add(item.IlceAd);
            }
        }
        private void cmbHastaneListe()
        {
            cmbHospital.Items.Clear();
            List<Hastaneler> hastane = hastanelerBLL.HastanelerListelemeID(cmbDistrict.SelectedIndex + 1);
            foreach (var item in hastane)
            {
                cmbHospital.Items.Add(item.HastaneAd);
            }
        }
        private void cmbPoliklinkListe()
        {
            List<Poliklinkler> pol = poliklinklerBLL.PoliklinklerListele();
            foreach (var item in pol)
            {
                cmbPolyclinic.Items.Add(item.PoliklinkAd);
            }
        }
        private void cmbBolumListe()
        {
            List<Bolumler> bolumler = bolumlerBLL.BolumleriListele();
            foreach (var item in bolumler)
            {
                cmbClinic.Items.Add(item.BolumAd);
            }
        }
        private void cmbDoktorListelme()
        {
            cmbDoctor.Items.Clear();
            // DoktorBilgileri doktor = doktorBilgileriBLL.DoktorBilgileriListeleID(cmbDistrict.SelectedIndex+1);//Doktor ID ile tekrar düzelt burayı
            List<DoktorBilgileri> doktor = doktorBilgileriBLL.DoktorBilgileriListele();
            foreach (var item in doktor)
            {
                cmbDoctor.Items.Add(item.Ad);
            }  
        }
        private void cmbSeansSaatListe()
        {
            cmbHours.Items.Clear();
            List<Saatler> saatler = saatlerBLL.SaatlerListele();
            foreach (var item in saatler)
            {
                if (item.SaatDurumu == false)
                {
                    cmbHours.Items.Add(item.Saat.ToString());
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Randevu alındığında;
            // MessageBox.Show("Sayın {Tugba Cevik}, {Dahiliye} bölümüne {20.01.1995} tarihli {14:00} seansına doktorumuz {Eda Turk}'dan randevu oluşturulmuştur.\nLütfen randevu saatinden 15 dk önce hastanemizde bulununuz.\nSağlıklı günler dileriz.","Randevu Oluşturuldu");           
            try
            {
                randevuGoruntuleme = new RandevuGoruntuleme();
                randevuGoruntuleme.HastaID = 1;
                randevuGoruntuleme.HastaAd = "Ahmet";           randevuGoruntuleme.BolumAd = cmbClinic.Text;
                if (monthCalendar1.SelectionRange.Start > DateTime.Now)
                {
                    randevuGoruntuleme.Tarih = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString());
                }
                else
                {
                    MessageBox.Show("Geçmiş tarih den randevu alamazsınız!");
                }
                Saatler saatler = new Saatler();
                if (cmbHours.SelectedItem.ToString() == cmbHours.SelectedItem.ToString())
                {
                    saatler.Saat = TimeSpan.Parse(cmbHours.SelectedItem.ToString());
                    saatler.SaatDurumu = true;
                    randevuGoruntuleme.Saat = TimeSpan.Parse(cmbHours.SelectedItem.ToString());
                    saatlerBLL.Update(saatler, saatler.SaatDurumu);
                }

                randevuGoruntulemeBLL.Add(randevuGoruntuleme);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RandevulariGoster()
        {
            listView1.Items.Clear();
            List<RandevuGoruntuleme> randevus = randevuGoruntulemeBLL.RandevuGoruntulemeListele();
            foreach (var item in randevus)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.HastaID.ToString();
                lvi.SubItems.Add(item.HastaAd);
                lvi.SubItems.Add(item.BolumAd);
                lvi.SubItems.Add(item.Tarih.ToShortDateString());
                lvi.SubItems.Add(item.Saat.ToString());
                listView1.Items.Add(lvi);

            }
        }
        private void RandevuAlma_Load(object sender, EventArgs e)
        {
            cmbIlListe();
            cmbBolumListe();
            cmbDoktorListelme();
            RandevulariGoster();
            this.Height = 375;
            monthCalendar1.ShowWeekNumbers = true;
            monthCalendar1.AddBoldedDate(DateTime.Now);
            monthCalendar1.ShowTodayCircle = true;
        }
        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlceListe();
        }
        private void CmbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHastaneListe();
        }
        private void CmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPoliklinkListe();
        }
        private void CmbClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbDoktorListelme();
        }
        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeansSaatListe();
        }
        private void btnRandevularim_Click(object sender, EventArgs e)
        {
            if (btnRandevularim.Text == "Randevularımı Göster")
            {
                this.Height = 660;
                btnRandevularim.Text = "Randevularımı Gösterme";
                listView1.Visible = true;
                RandevulariGoster();
            }
            else if (btnRandevularim.Text == "Randevularımı Gösterme")
            {
                this.Height = 375;
                btnRandevularim.Text = "Randevularımı Göster";
                listView1.Visible = false;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //YENI EKLENDI

        public void HastaIDGetir(int HastaId)
        {
            lblHastaID.Text = HastaId.ToString();
        }
    }
}
