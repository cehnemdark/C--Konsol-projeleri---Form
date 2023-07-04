// Random Komutu

//Random rastgele = new Random();
//int a;
//a = rastgele.Next(0, 10);
//Console.WriteLine(a);

// **************************

//Random rastgele = new Random();
//int a, b;
//a = rastgele.Next(0, 10);
//b = rastgele.Next(0, 10);
//Console.WriteLine(a);
//Console.WriteLine(b);

// **************************

//Random rastgele = new Random();
//int sayi;
//sayi = rastgele.Next(50);
//Console.WriteLine(sayi);    

//// ************************************
//Random rastgele = new Random();
//int s1;
//s1 = rastgele.Next();
//Console.WriteLine(s1);

// aynı örnek gelişmiş versiyonu

//Random rastgele = new Random();
//int s1;
//s1 = rastgele.Next();

//if (s1 >= 1000000000)
//{
//    Console.WriteLine(s1 + " - Milyar");
//}
//else if (s1 >= 1000000)
//{
//    Console.WriteLine(s1 + " - Milyon");
//}
//else if (s1 >= 1000)
//{
//    Console.WriteLine(s1 + " - Bin");
//}
//else
//{
//    Console.WriteLine(s1);
//}

// *****************************************
//Random rastgele = new Random();
//Console.WriteLine("**** Şehir atama programı ****");
//string[] sehirler = {"Adana", "Antalya", "İzmir", "Aydın", "İstanbul",
//   "Edirne", "Trabzon", "Samsun", "Ankara", "Konya", "Elazığ", "Malatya",
//    "Diyarbakır", "Şanlıurfa"};
//int a;
//a = rastgele.Next(0, sehirler.Length);
//Console.WriteLine(a);
//Console.WriteLine(sehirler[a]);

//**************************************************

using System;

namespace SayisalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotoNumaralari = new int[6]; // Loto numaraları için 6 elemanlı bir dizi oluşturuyoruz

            Random rnd = new Random(); // Rastgele sayılar üretmek için Random sınıfını kullanıyoruz

            Console.WriteLine("Sayısal Loto Çekilişi Sonuçları\n");

            // Loto numaralarını belirleyen for döngüsü
            for (int i = 0; i < lotoNumaralari.Length; i++)
            {
                int rastgeleSayi = rnd.Next(1, 50); // 1 ile 49 arasında rastgele bir sayı oluşturuyoruz

                // Daha önce çekilmemiş bir sayıya rastgele olarak karar veriyoruz
                while (Array.IndexOf(lotoNumaralari, rastgeleSayi) != -1)
                {
                    rastgeleSayi = rnd.Next(1, 50);
                }

                lotoNumaralari[i] = rastgeleSayi; // Loto numaraları dizisine rastgele seçilen sayıyı ekliyoruz
            }

            // Loto numaralarını küçükten büyüğe sıralıyoruz
            Array.Sort(lotoNumaralari);

            Console.WriteLine("Çekiliş sonuçları açıklandı!");

            Console.Write("\nLoto numaraları: ");

            // Loto numaralarını ekrana yazdırıyoruz
            for (int i = 0; i < lotoNumaralari.Length; i++)
            {
                Console.Write(lotoNumaralari[i] + " ");
            }

            Console.ReadLine(); // Konsol ekranının otomatik kapanmasını engellemek için readline fonksiyonunu kullanıyoruz
        }
    }
}
