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
    public partial class Frmilce : Form
    {
        IlceDal ilceDal = new IlceDal();
        private SqlConnection sqlConnection;
        private string connectionString = "Server=DESKTOP-ISGVDMV\\SQLEXPRESS; Initial Catalog=UniDB; integrated security=true";


        public Frmilce()
        {
            InitializeComponent();
        }

        private void Frmilce_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ilceDal.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Boş mesaj gönderemezsiniz.");
                return;
            }

            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO ilce(Ad) VALUES (@p1)", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@p1", textBox1.Text);
                    sqlCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Yorumunuz başarıyla veritabanına kaydedildi.");

            textBox1.Clear();


        }
    }
}
