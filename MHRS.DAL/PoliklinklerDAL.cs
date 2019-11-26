using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class PoliklinklerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public PoliklinklerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public List<Poliklinkler> GetAllPoliklinkler()
        {
            cmd = new SqlCommand("select * from Poliklinkler", cnn);
            List<Poliklinkler> poliklink = new List<Poliklinkler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    poliklink.Add(new Poliklinkler()
                    {
                        PoliklinkID=Convert.ToInt32(reader["PoliklinkID"]),
                        PoliklinkAd=reader["PoliklinkAd"].ToString()
                    });
                }
                reader.Close();
                return poliklink;
            }
            catch (Exception)
            {
                return poliklink;
            }
        }
        public Poliklinkler GetByIDPoliklinkler(int hastaneID)
        {
            cmd = new SqlCommand("select * from Poliklinkler where HastaneID=@hastaneId", cnn);
            cmd.Parameters.AddWithValue("@hastaneId", hastaneID);
            Poliklinkler poliklink = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                reader.Read();
                poliklink = new Poliklinkler()
                {
                    PoliklinkID = Convert.ToInt32(reader["PoliklinkID"]),
                    PoliklinkAd = reader["PoliklinkAd"].ToString()
                };
                reader.Close();
                return poliklink;
            }
            catch (Exception)
            {
                return poliklink;
            }
        }
    }
}
