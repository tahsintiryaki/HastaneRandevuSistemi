using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class MuayeneBilgileriDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public MuayeneBilgileriDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }

        //Muayene bilgilerini getir
        public List<MuayeneBilgileri> GetAllMuayeneBilgileri()
        {
            cmd = new SqlCommand("select * from MuayeneBilgileri", cnn);
            List<MuayeneBilgileri> mb = new List<MuayeneBilgileri>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    mb.Add(new MuayeneBilgileri()
                    {
                        HastaID = Convert.ToInt32(reader["HastaID"]),
                        HastaAd = reader["HastaAd"].ToString(),
                        TeshisAd = reader["TeshisAd"].ToString(),
                        Tarih=DateTime.Parse(reader["Tarih"].ToString()),
                        Saat=TimeSpan.Parse(reader["Saat"].ToString()),
                        MuayeneDurumu = reader["MuayeneDurumu"].ToString(),
                        Notlar=reader["Notlar"].ToString()
                    }); 
                }
                reader.Close();
                return mb;
            }
            catch (Exception)
            {
                return mb;
            }
        }

        //Hastaya göre muayene bilgileri getir
        public MuayeneBilgileri GetByIDMuayeneBilgileri(int HastaID)
        {
            cmd = new SqlCommand("select * from where HastaID=@hastaID", cnn);
            cmd.Parameters.AddWithValue("@hastaID", HastaID);
            MuayeneBilgileri mb = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                reader.Read();
                mb = new MuayeneBilgileri()
                {
                    HastaID = Convert.ToInt32(reader["HastaID"]),
                    HastaAd = reader["HastaAd"].ToString(),
                    TeshisAd = reader["TeshisAd"].ToString(),
                    Tarih = DateTime.Parse(reader["Tarih"].ToString()),
                    Saat = TimeSpan.Parse(reader["Saat"].ToString()),
                    MuayeneDurumu = reader["MuayeneDurumu"].ToString(),
                    Notlar = reader["Notlar"].ToString()
                };
                reader.Close();
                return mb;
            }
            catch (Exception)
            {
                return mb;
            }
        }

        //Muayene ekle
        public int MuayeneAdd(MuayeneBilgileri mb)
        {
            cmd = new SqlCommand("insert into MuayeneBilgileri(HastaID,HastaAd,TeshisAd,Tarih,Saat,MuayeneDurumu,Notlar) values('@hastaID','@hastaAd','@teshisAd','@tarih','@saat','@muayeneDurumu','@notlar') select hb.HastaID,hb.Ad,t.TeshisAd,s.Tarih,sa.Saat from RandevuOlusturma as ro join HastaBilgileri as hb on ro.HastaID=hb.HastaID join Teshisler as t on ro.TeshisID=t.TeshisID join Seanslar as s on ro.SeansID=s.SeansID join Saatler as sa on s.SaatID=sa.SaatID", cnn);
            cmd.Parameters.AddWithValue("@hastaID",mb.HastaID);
            cmd.Parameters.AddWithValue("@hastaAd",mb.HastaAd);
            cmd.Parameters.AddWithValue("@teshisAd",mb.TeshisAd);
            cmd.Parameters.AddWithValue("@tarih",mb.Tarih);
            cmd.Parameters.AddWithValue("@saat",mb.Saat);
            cmd.Parameters.AddWithValue("@muayeneDurumu",mb.MuayeneDurumu);
            cmd.Parameters.AddWithValue("@notlar",mb.Notlar);
            return ExecuteCommand();
        }

        //Muayene Güncelle, (Teşhis)
        public int TeshisiGuncelle(int HastaID, string TeshisAd)
        {
            cmd = new SqlCommand("update muayenebilgileri set teshisAd=@teshis where HastaID=@hastaID", cnn);
            cmd.Parameters.AddWithValue("@hastaID", HastaID);
            cmd.Parameters.AddWithValue("@teshis", TeshisAd);
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
