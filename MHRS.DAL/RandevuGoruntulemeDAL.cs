using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class RandevuGoruntulemeDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public RandevuGoruntulemeDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public List<RandevuGoruntuleme> GetAllRandevuGoruntuleme()
        {
            cmd = new SqlCommand("select * from RandevuGoruntuleme", cnn);
            List<RandevuGoruntuleme> randevular = new List<RandevuGoruntuleme>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    randevular.Add(new RandevuGoruntuleme()
                    {
                        HastaID=Convert.ToInt32(reader["HastaID"]),
                        HastaAd=reader["HastaAd"].ToString(),
                        BolumAd=reader["BolumAd"].ToString(),
                        Tarih=DateTime.Parse(reader["Tarih"].ToString()),
                        Saat=TimeSpan.Parse(reader["Saat"].ToString())
                    });
                }
                reader.Close();
                return randevular;
            }
            catch (Exception)
            {
                return randevular;
            }
        }
        public List<RandevuGoruntuleme> GetByIDRandevuGoruntuleme(int HastaID)
        {
            cmd = new SqlCommand("select * from RandevuGoruntuleme where HastaID=@hastaID", cnn);
            cmd.Parameters.AddWithValue("@hastaID", HastaID);
            List<RandevuGoruntuleme> randevu = new List<RandevuGoruntuleme>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    randevu.Add(new RandevuGoruntuleme()
                    {
                        HastaID = Convert.ToInt32(reader["HastaID"]),
                        HastaAd = reader["HastaAd"].ToString(),
                        BolumAd = reader["BolumAd"].ToString(),
                        Tarih = DateTime.Parse(reader["Tarih"].ToString()),
                        Saat = TimeSpan.Parse(reader["Saat"].ToString())
                    });
                }
                reader.Close();
                return randevu;
            }
            catch (Exception)
            {
                return randevu;
            }

        }
        public int RandevuAdd(RandevuGoruntuleme randevu)
        {
            //select hb.HastaID,hb.Ad,b.BolumAd,s.Tarih,sa.Saat from RandevuOlusturma as ro join HastaBilgileri as hb on ro.HastaID=hb.HastaID join Ilceler as ilce on ro.IlID=ilce.IlID join Hastaneler as h on ilce.IlceID=h.IlceID join Poliklinkler as p on h.HastaneID=p.HastaneID join Bolumler as b on p.PoliklinkID=b.PoliklinkID join Seanslar as s on ro.SeansID=s.SeansID join Saatler as sa on s.SaatID=sa.SaatID
            //,Tarih,Saat,

            cmd = new SqlCommand("insert into RandevuGoruntuleme(HastaID,HastaAd,BolumAd,Tarih,Saat) values('@hastaID','@hastaAd','@BolumAd','@tarih','@saat') ", cnn);
            cmd.Parameters.AddWithValue("@hastaID", randevu.HastaID);
            cmd.Parameters.AddWithValue("@hastaAd", randevu.HastaAd);
            cmd.Parameters.AddWithValue("@BolumAd", randevu.BolumAd);
            cmd.Parameters.AddWithValue("@tarih", randevu.Tarih);
           cmd.Parameters.AddWithValue("@saat", randevu.Saat);
            return ExecuteCommand();
        }

        int ExecuteCommand()
        {
            try
            {
                cnn.Open();
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
    }
}
