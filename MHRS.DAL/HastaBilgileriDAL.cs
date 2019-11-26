using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
    public class HastaBilgileriDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public HastaBilgileriDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }

        public List<HastaBilgileri> GetAllHastaBilgileri()
        {
            cmd = new SqlCommand("select TC_No,Ad,Soyad,Cinsiyet,Email,Parola,Telefon from HastaBilgileri", cnn);
            List<HastaBilgileri> hb = new List<HastaBilgileri>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    hb.Add(new HastaBilgileri()
                    {
                        Tc_No = reader["TC_No"].ToString(),
                        Ad = reader["Ad"].ToString(),
                        Soyad = reader["Soyad"].ToString(),
                        Cinsiyet = bool.Parse(reader["Cinsiyet"].ToString()),
                        Email = reader["Email"].ToString(),
                        Parola = reader["Parola"].ToString(),
                        Telefon = reader["Telefon"].ToString()
                    });
                }
                reader.Close();
                return hb;
            }
            catch (Exception)
            {
                return hb;
            }

        }

        public HastaBilgileri GetByIDHastaBilgileri(int HastaID)
        {
            cmd = new SqlCommand("select TC_No,Ad,Soyad,Cinsiyet,Email,Parola,Telefon from HastaBilgileri where HastaID=@hastaId", cnn);
            cmd.Parameters.AddWithValue("@hastaId", HastaID);
            HastaBilgileri hb = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                reader.Read();
                hb = new HastaBilgileri()
                {
                    Tc_No = reader["TC_No"].ToString(),
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    Cinsiyet = bool.Parse(reader["Cinsiyet"].ToString()),
                    Email = reader["Email"].ToString(),
                    Parola = reader["Parola"].ToString(),
                    Telefon = reader["Telefon"].ToString()
                };
                reader.Close();
                return hb;
            }
            catch (Exception)
            {
                return hb;
            }

        }

        public int AddHastaBilgileri(HastaBilgileri hasta)
        {
            cmd = new SqlCommand(@"Insert Into HastaBilgileri (Tc_No,Ad,Soyad,Cinsiyet,EMail,Sifre,Telefon,RolID) 
            values (@Tc_No,@Ad,@Soyad,@Cinsiyet,@EMail,@Sifre,@Telefon,@RolID)", cnn);
            cmd.Parameters.AddWithValue("@Tc_No", hasta.Tc_No);
            cmd.Parameters.AddWithValue("@Ad", hasta.Ad);
            cmd.Parameters.AddWithValue("@Soyad", hasta.Soyad);
            //cmd.Parameters.AddWithValue("@Cinsiyet", hasta.Cinsiyet);
            cmd.Parameters.AddWithValue("@EMail", hasta.Email);
            cmd.Parameters.AddWithValue("@Sifre", hasta.Parola);
            cmd.Parameters.AddWithValue("@Telefon", hasta.Telefon);
            cmd.Parameters.AddWithValue("@RolID", 1);
            return Execute();
        }

        int Execute()
        {
            try
            {
                if (cnn.State != System.Data.ConnectionState.Open)
                {
                    cnn.Open();
                }
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                cnn.Close();
            }
        }

        //Hasta eposta ve şifreye göre hasta ID gelecek  >>>>>>>>>>>> YENİ EKLENDİ
        public HastaBilgileri HastaIDGetir(string email, string sifre)
        {
            cmd = new SqlCommand("select HastaID from HastaBilgileri where email=@email and parola=@parola", cnn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@parola", sifre);
            HastaBilgileri hb = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                hb = new HastaBilgileri();




                reader.Read();
                hb = new HastaBilgileri()
                {
                    HastaID = (int)(reader["HastaID"]),

                };
                reader.Close();
                cnn.Close();
                return hb;
            }
            catch (Exception)
            {
                return hb;
            }

        }


    }
}
