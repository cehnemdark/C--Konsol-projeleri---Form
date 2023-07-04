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

            // �lk TextBox kontrol�ndeki ya� de�erini al�r ve bir say� olmad���n� kontrol eder
            if (!int.TryParse(textBox1.Text, out yas1))
            {
                MessageBox.Show("L�tfen sadece say�sal bir de�er girin.", "Hata");
                return;
            }
            // �kinci TextBox kontrol�ndeki ya� de�erini al�r ve bir say� olmad���n� kontrol eder
            if (!int.TryParse(textBox2.Text, out yas2))
            {
                MessageBox.Show("L�tfen sadece say�sal bir de�er girin.", "Hata");
                return;
            }
            // ���nc� TextBox kontrol�ndeki ya� de�erini al�r ve bir say� olmad���n� kontrol eder
            if (!int.TryParse(textBox3.Text, out yas3))
            {
                MessageBox.Show("L�tfen sadece say�sal bir de�er girin.", "Hata");
                return;
            }

            if (yas1 == 0 && yas2 == 0 && yas3 == 0) // Hi�bir veri girilmediyse hata mesaj� g�sterir
            {
                MessageBox.Show("L�tfen en az bir ki�inin ya�� hakk�nda bilgi girin.", "Hata");
                return;
            }

            // Ya� de�erlerine g�re hesaplama yapar ve sonucu Label kontrol�ne yazd�r�r
            yas1 = CalculateAgeCost(yas1);
            yas2 = CalculateAgeCost(yas2);
            yas3 = CalculateAgeCost(yas3);

            int toplamucret = yas1 + yas2 + yas3;
            label4.Text = toplamucret.ToString() + "TL";
        }

        // Ya� de�erine g�re �cret hesaplamas� yapar
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
