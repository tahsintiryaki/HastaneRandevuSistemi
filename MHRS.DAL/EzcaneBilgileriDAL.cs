using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class EzcaneBilgileriDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public EzcaneBilgileriDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public List<EzcaneBilgileri> GetAllEzcaneBilgileri()
        {
            cmd = new SqlCommand("select * from EzcaneBilgileri", cnn);
            List<EzcaneBilgileri> eb = new List<EzcaneBilgileri>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    eb.Add(new EzcaneBilgileri()
                    {
                        EzcaneID=Convert.ToInt32(reader["EzcaneID"]),
                        EzcaneAdi=reader["EzcaneAdi"].ToString(),
                        Email=reader["Email"].ToString(),
                        Parola=reader["Parola"].ToString()
                    });
                }
                reader.Close();
                return eb;
            }
            catch (Exception)
            {
                return eb;
            }
        }
    }
}
