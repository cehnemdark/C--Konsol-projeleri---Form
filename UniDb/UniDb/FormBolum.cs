using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniDb.DataAccessLeyer;

namespace UniDb
{
    public partial class FormBolum : Form
    {
        bolumDal _bolumDal = new bolumDal();
        public FormBolum()
        {
            InitializeComponent();
        }

        private void FormBolum_Load(object sender, EventArgs e)
        {
            dataGridView3.DataSource = _bolumDal.GetAll();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
