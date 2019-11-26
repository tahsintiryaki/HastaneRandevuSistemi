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

namespace MHRS.UI
{
    public partial class EczanePaneli : Form
    {
        RecetelerBLL _recetelerBLL;        
        HastaBilgileriBLL _hastaBilgileriBLL;
        Receteler _recete;

        public EczanePaneli()
        {
            InitializeComponent();
            _recetelerBLL = new RecetelerBLL();           
            _hastaBilgileriBLL = new HastaBilgileriBLL();
        }

        private void btnReceteGetir_Click(object sender, EventArgs e)
        {
            Frm_ListViewDoldur();
        }
        private void btnİlaclariGetir_Click(object sender, EventArgs e)
        {
            Frm_ListBoxDoldur();
        }

        private void EczanePaneli_Load(object sender, EventArgs e)
        {

        }

        //Hastanın reçetelerini getirip listviewe yazdıran metod.
        private void Frm_ListViewDoldur()
        {
            lstReceteler.Items.Clear();
            List<Receteler> _recete = _recetelerBLL.RecetelerListeleHastaID(int.Parse(txtHastaID.Text));

            ListViewItem lvi;
            foreach (var item in _recete)
            {
                lvi = new ListViewItem();
                lvi.Text = item.ReceteKodu.ToString();
                lvi.SubItems.Add(item.Ilaclar);
                lvi.Tag = item;
                lstReceteler.Items.Add(lvi);

            }

        }

        //İlaçları getirip listboxa yazan metod.
        private void Frm_ListBoxDoldur()
        {
            lstilaclar.Items.Clear();
            _recete = new Receteler();
            _recete = _recetelerBLL.RecetelerListeleReceteKodu(int.Parse(txtReceteID.Text));
            string ilaclar = _recete.Ilaclar.ToString();
            lstilaclar.Items.Add(ilaclar);
        }

    }
}
