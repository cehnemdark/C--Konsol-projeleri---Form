namespace SayıTekMiCiftMi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);

            if (num % 2 == 0)
                MessageBox.Show("Sayı çifttir.");
            else
                MessageBox.Show("Sayı tektir.");
        }
    }
}
