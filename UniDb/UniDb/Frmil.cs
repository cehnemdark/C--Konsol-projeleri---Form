using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniDb.DataAccessLeyer;

namespace UniDb
{
    public partial class Frmil : Form
    {
        IlDal ilDal = new IlDal();
        private SqlConnection sqlConnection;
        private string connectionString = "Server=DESKTOP-ISGVDMV\\SQLEXPRESS; Initial Catalog=UniDB; integrated security=true";
        public Frmil()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmil_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ilDal.GetAll();

        }

        private void BtnSend2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Boş mesaj gönderemezsiniz.");
                return;
            }

            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO TblIl(Ad) VALUES (@p1)", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@p1", textBox2.Text);
                    sqlCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Yorumunuz başarıyla veritabanına kaydedildi.");

            textBox2.Clear();
        }
    }
}
