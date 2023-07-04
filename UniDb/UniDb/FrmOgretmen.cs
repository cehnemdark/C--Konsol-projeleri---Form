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
    public partial class FrmOgretmen : Form
    {
        OgretmenDal ogretmenDal = new OgretmenDal();
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            dataGridView4.DataSource = ogretmenDal.GetAll();
        }
    }
}
