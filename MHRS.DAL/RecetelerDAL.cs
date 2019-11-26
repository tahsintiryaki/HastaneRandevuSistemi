using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class RecetelerDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public RecetelerDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        public Receteler GetByCodeReceteler(int receteKodu)
        {
            cmd = new SqlCommand("select Ilaclar from Receteler where ReceteKodu=@kodu", cnn);
            cmd.Parameters.AddWithValue("@kodu", receteKodu);
            Receteler rKodu = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                reader.Read();
                rKodu = new Receteler()
                {
                    Ilaclar = reader["Ilaclar"].ToString()
                };
                reader.Close();
                return rKodu;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Receteler> GetByHastaIDReceteler(int HastaID)
        {
            cmd = new SqlCommand("select ReceteKodu,Ilaclar from Receteler where HastaID=@hastaID", cnn);
            cmd.Parameters.AddWithValue("@hastaID", HastaID);
            List<Receteler> receteler = new List<Receteler>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    receteler.Add(new Receteler()
                    {
                        ReceteKodu = Convert.ToInt32(reader["ReceteKodu"]),
                        Ilaclar = reader["Ilaclar"].ToString()
                    });
                }
                reader.Close();
                return receteler;
            }
            catch (Exception)
            {
                return receteler;
            }
        }

        //Recete ekle
        public int ReceteEkle(Receteler recete)
        {
            cmd = new SqlCommand("insert into Receteler (ReceteKodu,HastaID,ilaclar) values (@receteKod,@HastaID,@ilac)", cnn);
            cmd.Parameters.AddWithValue("@receteKod", recete.ReceteKodu);
            cmd.Parameters.AddWithValue("@HastaID", recete.HastaID);
            cmd.Parameters.AddWithValue("@ilac", recete.Ilaclar);
            return ExecuteCommand();
        }

        int ExecuteCommand()
        {
            try
            {
                cnn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception )
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
