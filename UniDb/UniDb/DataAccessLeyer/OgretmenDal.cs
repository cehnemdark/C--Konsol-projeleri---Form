using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniDb.SomutNesneler;

namespace UniDb.DataAccessLeyer
{
    public class OgretmenDal
    {

        public List<Ogretmen> GetAll()
        {   
            List<Ogretmen> Ogretmenler = new List<Ogretmen>();
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-ISGVDMV\\SQLEXPRESS; Initial Catalog=UniDB; integrated security=true");
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();               
            }
            SqlCommand sqlCommand = new SqlCommand("Select * From TblOgretmen", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Ogretmen ogretmen = new Ogretmen
                {
                    Id = Convert.ToInt32(sqlDataReader["OgretmenId"]),
                    FirstName = sqlDataReader["Ad"].ToString(),

                    LastName = sqlDataReader["Soyad"].ToString(),
                    Phone = sqlDataReader["Tel"].ToString(),

                };
                Ogretmenler.Add(ogretmen);
            }
            sqlConnection.Close();
            return Ogretmenler;
           
        }
    }

}
