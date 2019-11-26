using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class SaatlerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public SaatlerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }

        public List<Saatler> GetAllSaatler()
        {
            cmd = new SqlCommand("select Saat,SaatDurumu from Saatler", cnn);
            List<Saatler> saat = new List<Saatler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    saat.Add(new Saatler()
                    {
                        Saat=TimeSpan.Parse(reader["Saat"].ToString()),
                        SaatDurumu=Boolean.Parse(reader["SaatDurumu"].ToString())
                    });
                }
                reader.Close();
                return saat;
            }
            catch (Exception)
            {
                return saat;
            }
        }

        public List<Saatler> MusaitSaatleriGetir()
        {
            cmd = new SqlCommand("select Saat from Saatler where saatDurumu='False' ", cnn);
            List<Saatler> saat = new List<Saatler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    saat.Add(new Saatler()
                    {
                        Saat = TimeSpan.Parse(reader["Saat"].ToString())
                        
                    });
                }
                reader.Close();
                return saat;
            }
            catch (Exception)
            {
                return saat;
            }
        }



        public Saatler GetByIDSaatler(bool SaatDurumu)
        {
            cmd = new SqlCommand("select * form Saatler where SaatDurumu=@saatDurum", cnn);
            cmd.Parameters.AddWithValue("@saatDurum", SaatDurumu);
            Saatler saat = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                reader.Read();
                saat = new Saatler()
                {
                    SaatID= Convert.ToInt32(reader["SaatID"]),
                    Saat = TimeSpan.Parse(reader["Saat"].ToString()),
                    SaatDurumu = Boolean.Parse(reader["SaatDurumu"].ToString())
                };
                reader.Close();
                return saat;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdateSaatDurumu(Saatler saatler)
        {
            cmd = new SqlCommand("update Saatler set SaatDurumu=@durum where Saat=@saat", cnn);
            cmd.Parameters.AddWithValue("@saat", saatler.Saat);
            cmd.Parameters.AddWithValue("@durum", saatler.SaatDurumu);
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
