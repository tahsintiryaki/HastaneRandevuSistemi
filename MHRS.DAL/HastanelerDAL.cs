using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class HastanelerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public HastanelerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public List<Hastaneler> GetAllHastaneler()
        {
            cmd = new SqlCommand("select HastaneID,HastaneAd from Hastaneler", cnn);
            List<Hastaneler> hastane = new List<Hastaneler>();
            try
            {
                cnn.Open();
                 SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    hastane.Add(new Hastaneler()
                    {
                        HastaneID=Convert.ToInt32(reader["HastaneID"]),
                        HastaneAd=reader["HastaneAd"].ToString()
                    });
                }
                reader.Close();
                return hastane;
            }
            catch (Exception)
            {
                return hastane;
            }
        }
        public List<Hastaneler> GetByIDHastaneler(int ilceID)
        {
            cmd = new SqlCommand("select * from Hastaneler where IlceID=@ilceID", cnn);
            cmd.Parameters.AddWithValue("@ilceID", ilceID);
            List<Hastaneler> hastane = new List<Hastaneler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    hastane.Add(new Hastaneler()
                    {
                        HastaneID = Convert.ToInt32(reader["HastaneID"]),
                        HastaneAd = reader["HastaneAd"].ToString()
                    });
                }
                reader.Close();
                return hastane;
            }
            catch (Exception)
            {
                return hastane;
            }
        }
    }
}
