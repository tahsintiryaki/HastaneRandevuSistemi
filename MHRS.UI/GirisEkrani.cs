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
using MHRS.UI;

namespace MHRS
{
    public partial class GirisEkrani : Form
    {
        HastaBilgileriBLL hastaBilgileriBLL;
        RollerBLL rollerBLL;
        UyeGiris uyeGiris;
        HastaBilgileri hastaBilgileri;

        public int HastaID;

       
        public GirisEkrani()
        {
            InitializeComponent();
            hastaBilgileriBLL = new HastaBilgileriBLL();
            rollerBLL = new RollerBLL(); 
        }       

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UyeOl frmUye = new UyeOl();
            frmUye.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            uyeGiris = new UyeGiris();
            uyeGiris.Email = txtUsername.Text;
            uyeGiris.Parola = txtPassword.Text;
            uyeGiris.RolID = comboBox1.SelectedIndex + 1;

            try
            {
                hastaBilgileriBLL.GirisKontrol(uyeGiris.Email, uyeGiris.Parola,uyeGiris.RolID);
              
                //LoginControl
                if (uyeGiris.RolID == 1) // Hasta ise
                {
                    //Burada email ve sifreye göre hasta ID'sini alacağız bu yüzden hastabilgilerinden instance alıyoruz.
                    hastaBilgileri = new HastaBilgileri();

                    //Globalde int HastaId diye değişken tanımlamıştık BLL'den çıkan sonucu ona atıyoruz.
                    hastaBilgileri=hastaBilgileriBLL.HastaIdGetir(uyeGiris.Email, uyeGiris.Parola);
                    HastaID = hastaBilgileri.HastaID;
                    
                    //Hasta eposta ve parola doğruysa Randevu Alma formuna geçiş yapılıyor, bu işlem için öncelikle instance alıyoruz.
                    RandevuAlma randevu = new RandevuAlma();

                    //RandevuAlmada public bir metod tanımladık(HastaIDGetir) hastaID'yi alıp formda kullanacağız.
                    randevu.HastaIDGetir(HastaID);
                    randevu.ShowDialog();

                }
                else if (uyeGiris.RolID == 2) //Doktor ise
                {
                  //Deneme  MessageBox.Show("Doktor");
                    DoktorPaneli frmDoktorPaneli = new DoktorPaneli();
                    frmDoktorPaneli.ShowDialog();
                }
                else if (uyeGiris.RolID == 3)//Eczane ise
                {
                  //Deneme  MessageBox.Show("Ezcane");
                    EczanePaneli frmEczanePaneli = new EczanePaneli();
                    frmEczanePaneli.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = rollerBLL.RollerListele();
            comboBox1.DisplayMember = "Rolu";
            comboBox1.ValueMember = "RolID";
            //foreach (Roller item in rol)
            //{
            //    comboBox1.Items.Add(item.Rolu);
            //} 
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = " ";
        }
    }
}
