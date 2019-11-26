using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class IlcelerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public IlcelerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public List<Ilceler> GetAllIlceler()
        {
            cmd = new SqlCommand("select * from Ilceler", cnn);
            List<Ilceler> ilce = new List<Ilceler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    ilce.Add(new Ilceler()
                    {
                        IlceID=Convert.ToInt32(reader["IlceID"]),
                        IlceAd=reader["IlceAd"].ToString()
                    });
                }
                reader.Close();
                return ilce;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Ilceler> GetByIDIlceler(int ilID)
        {
            cmd = new SqlCommand("select IlceID,IlceAd from Ilceler where IlID=@ilID", cnn);
            cmd.Parameters.AddWithValue("@ilID", ilID);
            List<Ilceler> ilce = new List<Ilceler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    ilce.Add(new Ilceler()
                    {
                        IlceID=Convert.ToInt32(reader["IlceID"]),
                        IlceAd=reader["IlceAd"].ToString()
                    });
                }
                reader.Close();
                return ilce;
            }
            catch (Exception)
            {
                return ilce;
            }
        }
    }
}
