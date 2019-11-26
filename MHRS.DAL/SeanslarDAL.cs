using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class SeanslarDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public SeanslarDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public List<Seansler> GetAllSeansler()
        {
            List<Seansler> seans = new List<Seansler>();
            cmd = new SqlCommand("select * from Seanslar",cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    seans.Add(new Seansler()
                    {
                        Tarih=DateTime.Parse(reader["Tarih"].ToString()),
                        SaatID=Convert.ToInt32(reader["SaatID"])
                    });
                }
                reader.Close();
                return seans;
            }
            catch (Exception)
            {
                return seans;
            }
        }


    }
}
