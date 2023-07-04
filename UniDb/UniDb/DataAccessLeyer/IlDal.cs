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
    public class IlDal
    {
        public List<Il> GetAll()
        {
            List<Il> iller = new List<Il>();
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-ISGVDMV\\SQLEXPRESS; Initial Catalog=UniDB; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Select * From TblIl", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Il il = new Il
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = sqlDataReader["Ad"].ToString(),
                };
                iller.Add(il);
            }
            sqlConnection.Close();

            return iller;
        }
    }
}
