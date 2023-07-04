namespace UniDb
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnilceler_Click(object sender, EventArgs e)
        {
            Frmilce frmIlceler = new Frmilce();
            Hide();
            frmIlceler.Show();
        }

        private void btnil_Click(object sender, EventArgs e)
        {
            Frmil frmil = new Frmil();
            Hide();

            frmil.Show();
        }

        private void btlbolum_Click(object sender, EventArgs e)
        {

            FormBolum FormBolum = new FormBolum();
            Hide();

            FormBolum.Show();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {

        }

        private void btnOgretmen_Click_1(object sender, EventArgs e)
        {
            FrmOgretmen frmOgretmen = new FrmOgretmen();
            this.Hide();
            frmOgretmen.Show();
        }
    }
}