using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class IllerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public IllerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public List<Iller> GetAllIller()
        {
            cmd = new SqlCommand("select * from Iller", cnn);
            List<Iller> il = new List<Iller>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    il.Add(new Iller()
                    {
                        IlID = Convert.ToInt32(reader["IlID"]),
                        IlAd = reader["IlAd"].ToString()
                    }); 
                }
                reader.Close();
                return il;
            }
            catch (Exception)
            {
                return il;
            }
        }
    }
}
