using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class RollerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public RollerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public List<Roller> RolleriGoster()
        {
            List<Roller> roller = new List<Roller>();
            cmd = new SqlCommand("select * from Roller", cnn);
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (rd.Read())
                {
                    roller.Add(new Roller()
                    {
                        RolID = Convert.ToInt32(rd["RolID"]),
                        Rolu = rd["Rolu"].ToString(),
                    });
                }
                rd.Close();
                return roller;
            }
            catch (Exception)
            {
                return roller;
            }
           
        }
    }
}
