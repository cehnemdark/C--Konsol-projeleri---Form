namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            string kanGrubu = txtKanGrubu.Text.ToUpper();

            switch (kanGrubu)
            {
                case "A+":
                    lblSonuc.Text = "A+ ve AB+ kan gruplarýna kan verebilirsiniz.";
                    break;
                case "A-":
                    lblSonuc.Text = "A+, A-, AB+ ve AB- kan gruplarýna kan verebilirsiniz.";
                    break;
                case "B+":
                    lblSonuc.Text = "B+ ve AB+ kan gruplarýna kan verebilirsiniz.";
                    break;
                case "B-":
                    lblSonuc.Text = "B+, B-, AB+ ve AB- kan gruplarýna kan verebilirsiniz.";
                    break;
                case "AB+":
                    lblSonuc.Text = "AB+ kan grubuna kan verebilirsiniz.";
                    break;
                case "AB-":
                    lblSonuc.Text = "AB+ ve AB- kan gruplarýna kan verebilirsiniz.";
                    break;
                case "0+":
                    lblSonuc.Text = "A+, B+, AB+ ve 0+ kan gruplarýna kan verebilirsiniz.";
                    break;
                case "0-":
                    lblSonuc.Text = "Tüm kan gruplarýna kan verebilirsiniz.";
                    break;
                default:
                    lblSonuc.Text = "Lütfen geçerli bir kan grubu girin.";
                    break;
            }
        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
