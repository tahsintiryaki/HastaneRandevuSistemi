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
    public partial class UyeOl : Form
    {
        HastaBilgileriBLL hastaBilgileriBLL;
        UyeGirisBLL uyeGirisBLL;
        HastaBilgileri hasta;
        UyeGiris uye;

        public UyeOl()
        {
            InitializeComponent();
            hastaBilgileriBLL = new HastaBilgileriBLL();
            uyeGirisBLL = new UyeGirisBLL();
        }

        //Giriş yap butonu;
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                hasta= new HastaBilgileri();
                uye = new UyeGiris();
                uye.Email = txtMail.Text;
                uye.Parola = txtPswrd.Text;
                uye.RolID = 1;
                try
                {
                    hasta.Tc_No = txtTC.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                hasta.Ad = txtName.Text;
                hasta.Soyad = txtSurname.Text;
                hasta.Email = txtMail.Text;
                hasta.Parola = txtPswrd.Text;
                hasta.Telefon = txtPhone.Text;
                
                if (rbMale.Checked)
                {
                    hasta.Cinsiyet = false;
                }
                else
                {
                    hasta.Cinsiyet = true;
                }
                uyeGirisBLL.Add(uye);
                hastaBilgileriBLL.HastaEkle(hasta);

                DialogResult result=MessageBox.Show("Kayıt başarılı, çıkmak için OK'a basın.","Kayıt Oluşturuldu",MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Uye Ol form Load; 
        private void UyeOl_Load(object sender, EventArgs e)
        {
            
        }

        //Şifreyi göster gizle;
        private void lblSifreyiGoster_Click(object sender, EventArgs e)
        {
            if(lblSifreyiGoster.Text== "Şifreyi Göster")
            {
                this.txtPswrd.PasswordChar = '\0';
                lblSifreyiGoster.Text = "Şifreyi Gizle";

            }
            else if(lblSifreyiGoster.Text == "Şifreyi Gizle")
            {
                this.txtPswrd.PasswordChar = '*';
                lblSifreyiGoster.Text = "Şifreyi Göster";

            }

        }
    }
}
