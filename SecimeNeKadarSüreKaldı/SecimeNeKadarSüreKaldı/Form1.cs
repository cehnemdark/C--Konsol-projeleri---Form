using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SecimeNeKadarSüreKaldı
{
    public partial class Form1 : Form
    {
        private const string connectionString = @"Server=DESKTOP-ISGVDMV\SQLEXPRESS; Initial Catalog=DbGeriBildirim; integrated security=true";

        private SqlConnection sqlConnection;

        public Form1()
        {

            InitializeComponent();
        }

        private void RemainingTime()
        {
            DateTime date1 = DateTime.Now;
            DateTime date2 = new DateTime(2023, 5, 28);

            if (date2 < date1)
            {
                date2 = date2.AddYears(1);
            }

            TimeSpan remainingTime = date2 - date1;
            label2.Text = remainingTime.Days.ToString();
            label3.Text = remainingTime.Hours.ToString();
            label7.Text = remainingTime.Minutes.ToString();
            label8.Text = remainingTime.Seconds.ToString();
            label11.Text = remainingTime.Milliseconds.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            ShowFeedbacks();
            RemainingTime();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RemainingTime();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Boş mesaj gönderemezsiniz.");
                return;
            }

            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO GeriBildirimler(Açıklama) VALUES (@p1)", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@p1", richTextBox1.Text);
                    sqlCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Yorumunuz başarıyla veritabanına kaydedildi.");

            richTextBox1.Clear();

            ShowFeedbacks();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Açıklama"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM GeriBildirimler WHERE ID = @p1", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@p1", id);
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                ShowFeedbacks();
            }
        }



        private void ShowFeedbacks()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM GeriBildirimler", sqlConnection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                string newAçıklama = textBox2.Text;

                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("UPDATE GeriBildirimler SET Açıklama = @p1 WHERE ID = @p2", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@p1", newAçıklama);
                        sqlCommand.Parameters.AddWithValue("@p2", id);
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                ShowFeedbacks();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}