using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniDb.SomutNesneler;

namespace UniDb.DataAccessLeyer
{
    public class IlceDal
    {
        public List<Ilce> GetAll()
        {
            List<Ilce> ilceler = new List<Ilce>();
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-ISGVDMV\\SQLEXPRESS; Initial Catalog=UniDB; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Select * From ilce", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Ilce ilce = new Ilce
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = sqlDataReader["Ad"].ToString(),
                };
                ilceler.Add(ilce);
            }
            sqlConnection.Close();

            return ilceler;
        }
    }
}
