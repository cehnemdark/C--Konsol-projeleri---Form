//int sinav1, sinav2, proje, ortalama;
//Console.WriteLine("Birinci sınavı giriniz: ");
//sinav1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("İkinci sınavı giriniz: ");
//sinav2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Proje notunu giriniz: ");
//proje = Convert.ToInt32(Console.ReadLine());

//ortalama = (sinav1 + sinav2 + proje) / 3;
//Console.WriteLine("Ortalama: " + ortalama);

//if (ortalama > 0 && ortalama < 30)
//{
//    Console.WriteLine("Durum: Çok kötü ");
//}
//else if (ortalama >= 30 && ortalama < 50)
//{
//    Console.WriteLine("Durum: İyi değil");
//}
//else if (ortalama >= 50 && ortalama < 75)
//{
//    Console.WriteLine("Durum: İyi");
//}
//else if (ortalama >= 75 && ortalama < 90)
//{
//    Console.WriteLine("Durum: Çok iyi");
//}
//else if (ortalama >= 90 && ortalama <= 100)
//{
//    Console.WriteLine("Durum: Harika");
//}
//else if (ortalama > 100)
//{
//    Console.WriteLine("Girdiğin değerlerde bir yanlışlık var, lütfen tekrar kontrol ediniz.");
//}

// ********************************************************************************************

// Klavyeden girilien sayının tek mi çift olduğunu bulan program

// && Ve sembolü
// % Mod alma

//int sayi;
//Console.Write("Sayıyı giriniz: ");
//sayi = Convert.ToInt32(Console.ReadLine());

//if (sayi % 2==0)
//{
//    Console.Write("Sayı çifttir.");

//}else
//{
//    Console.WriteLine("Sayı tektir.") ;
//}

// ******************************************************************************************

// Klavyeden girilen sayının 5'e tam bölünüp bölünmediğini bulan program

int sayi;
Console.WriteLine("Sayıyı girin: ");
sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 5 == 0)
{
    Console.WriteLine("Sayı 5'e tam bölünür.");

}
else
{
     Console.WriteLine("Sayı 5'e tam bölünmez");
}
Console.ReadLine();
