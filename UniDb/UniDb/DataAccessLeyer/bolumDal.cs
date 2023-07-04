using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniDb.SomutNesneler;

namespace UniDb.DataAccessLeyer
{
    public class bolumDal
    {

        public List<bolum> GetAll()
        {
            List<bolum> bolumler = new List<bolum>();
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-ISGVDMV\\SQLEXPRESS; Initial Catalog=UniDB; integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Select * From TblBolum", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                bolum bolum = new bolum
                {
                    Id = Convert.ToInt32(sqlDataReader["BolumId"]),
                    Name = sqlDataReader["BolumAd"].ToString(),
                };
                bolumler.Add(bolum);
            }
            sqlConnection.Close();

            return bolumler;
        }
    }
}