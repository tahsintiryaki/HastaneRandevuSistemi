using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class UyeGirisDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public UyeGirisDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public List<UyeGiris> UyeGirisiGoruntule()
        {
            List<UyeGiris> uyegirisi = new List<UyeGiris>();
            cmd = new SqlCommand("Select EMail,Sifre,RolID from UyeGirisi", cnn);
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (rd.Read())
                {
                    uyegirisi.Add(new UyeGiris()
                    {
                        Email = rd["EMail"].ToString(),
                        Parola = rd["Sifre"].ToString(),
                        RolID = Convert.ToInt32(rd["RolID"]),
                    });
                }
                rd.Close();
                return uyegirisi;
            }
            catch (Exception)
            {
                return uyegirisi;
            }
        }
        public int HastaAdd(UyeGiris uye)
        {
            cmd = new SqlCommand("insert into UyeGirisi values (@Mail,@Parola,@Rolid)",cnn);
            cmd.Parameters.AddWithValue("@Mail", uye.Email);
            cmd.Parameters.AddWithValue("@Parola", uye.Parola);
            cmd.Parameters.AddWithValue("@Rolid", uye.RolID);
            return ExecuteCommand();
        }
        int ExecuteCommand()
        {
            try
            {
                if (cnn.State != System.Data.ConnectionState.Open)
                {
                    cnn.Open();
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                return -1;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
