using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MHRS.Entities;

namespace MHRS.DAL
{
   public class DoktorBilgileriDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public DoktorBilgileriDAL()
        {
            cnn = new SqlConnection(Properties.Settings.Default.Cnn);
        }
        //Tüm doktorları görüntüleyen fonksiyon
        public List<DoktorBilgileri> AllGetDoktorBilgileri()
        {
            cmd = new SqlCommand("select * from DoktorBilgileri", cnn);
            List<DoktorBilgileri> db = new List<DoktorBilgileri>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    db.Add(new DoktorBilgileri
                    {
                        Ad=reader["Ad"].ToString(),
                        Soyad=reader["Soyad"].ToString(),
                        BolumID=Convert.ToInt32(reader["BolumID"]),
                        Cinsiyet=bool.Parse(reader["Cinsiyet"].ToString()),
                        Email=reader["Email"].ToString(),
                        Parola=reader["Parola"].ToString(),
                        Telefon=reader["Telefon"].ToString()
                    });
                }
                reader.Close();
                return db;
            }
            catch (Exception ex)
            {
                return db;
            }
        }
        //DoktorID'si ne göre görüntüleyen fonksiyon
        public DoktorBilgileri GetByIdDoktorBilgileri(int DoktorID)
        {
            cmd = new SqlCommand("select * from DoktorBilgileri where DoktorID=@DoktorId", cnn);
            cmd.Parameters.AddWithValue("@DoktorId", DoktorID);
            DoktorBilgileri db = null;
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                reader.Read();
                db = new DoktorBilgileri()
                {
                    DoktorID = Convert.ToInt32(reader["DoktorID"]),
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    BolumID = Convert.ToInt32(reader["BolumID"]),
                    Cinsiyet = bool.Parse(reader["Cinsiyet"].ToString()),
                    Email = reader["Email"].ToString(),
                    Parola = reader["Parola"].ToString(),
                    Telefon = reader["Telefon"].ToString()
                };
                reader.Close();
                return db;
            }
            catch (Exception)
            {
                return db;
            }
        }
    }
}
