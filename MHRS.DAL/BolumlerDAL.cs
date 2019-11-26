using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
    
   public class BolumlerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public BolumlerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        //Tüm bölümleri getiren fonksiyon
        public List<Bolumler> AllGetBolumler()
        {
            cmd = new SqlCommand("select * from Bolumler", cnn);
            List<Bolumler> blm = new List<Bolumler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    blm.Add(new Bolumler()
                    {
                        BolumID=Convert.ToInt32(reader["BolumID"]),
                        BolumAd=reader["BolumAd"].ToString(),
                        PoliklinkID=Convert.ToInt32(reader["PoliklinkID"])
                    });
                }
                reader.Close();
                return blm;
            }
            catch (Exception)
            {

                return blm;
            }
        }
        //BolumID'si göre bölüm getiren fonksiyon
        public Bolumler GetByIDBolum(int BolumID)
        {
            cmd = new SqlCommand("select * from Bolumler where BolumID=@BolumId", cnn);
            cmd.Parameters.AddWithValue("@BolumId", BolumID);
            Bolumler blm = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                reader.Read();
                blm = new Bolumler()
                {
                    BolumID=Convert.ToInt32(reader["BolumID"]),
                    BolumAd=reader["BolumAd"].ToString(),
                    PoliklinkID=Convert.ToInt32(reader["PoliklinkID"])
                };
                reader.Close();
                return blm;
            }
            catch (Exception)
            {
                return blm;
            }
        }
    }
}
