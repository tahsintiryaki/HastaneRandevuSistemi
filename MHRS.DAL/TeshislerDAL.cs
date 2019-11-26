using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class TeshislerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public TeshislerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }

        //Teshisleri getir
        public List<Teshisler> GetAllTeshisler()
        {
            List<Teshisler> teshis = new List<Teshisler>();
            cmd = new SqlCommand("select * from Teshisler", cnn);
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (rd.Read())
                {
                    teshis.Add(new Teshisler()
                    {
                        TeshisAd = rd["TeshisAd"].ToString()
                    });
                }
                rd.Close();
                return teshis;
            }
            catch (Exception)
            {
                return teshis;
            }
        }


    }
}
