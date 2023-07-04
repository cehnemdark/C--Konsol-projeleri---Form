using System;
using System.Windows.Forms;

namespace YasaGoreOdeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas1 = 0;
            int yas2 = 0;
            int yas3 = 0;

            // Ýlk TextBox kontrolündeki yaþ deðerini alýr ve bir sayý olmadýðýný kontrol eder
            if (!int.TryParse(textBox1.Text, out yas1))
            {
                MessageBox.Show("Lütfen sadece sayýsal bir deðer girin.", "Hata");
                return;
            }
            // Ýkinci TextBox kontrolündeki yaþ deðerini alýr ve bir sayý olmadýðýný kontrol eder
            if (!int.TryParse(textBox2.Text, out yas2))
            {
                MessageBox.Show("Lütfen sadece sayýsal bir deðer girin.", "Hata");
                return;
            }
            // Üçüncü TextBox kontrolündeki yaþ deðerini alýr ve bir sayý olmadýðýný kontrol eder
            if (!int.TryParse(textBox3.Text, out yas3))
            {
                MessageBox.Show("Lütfen sadece sayýsal bir deðer girin.", "Hata");
                return;
            }

            if (yas1 == 0 && yas2 == 0 && yas3 == 0) // Hiçbir veri girilmediyse hata mesajý gösterir
            {
                MessageBox.Show("Lütfen en az bir kiþinin yaþý hakkýnda bilgi girin.", "Hata");
                return;
            }

            // Yaþ deðerlerine göre hesaplama yapar ve sonucu Label kontrolüne yazdýrýr
            yas1 = CalculateAgeCost(yas1);
            yas2 = CalculateAgeCost(yas2);
            yas3 = CalculateAgeCost(yas3);

            int toplamucret = yas1 + yas2 + yas3;
            label4.Text = toplamucret.ToString() + "TL";
        }

        // Yaþ deðerine göre ücret hesaplamasý yapar
        private int CalculateAgeCost(int age)
        {
            if (age < 6)
            {
                return 0;
            }
            else if (6 <= age && age <= 12)
            {
                return 60;
            }
            else
            {
                return 120;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
