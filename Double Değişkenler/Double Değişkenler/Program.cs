Console.WriteLine("Öğrenci Not Hesaplama");

double sinav1, sinav2, sinav3, proje, ort;
string ad, soyad, numara;

Console.WriteLine();

Console.WriteLine("**** Öğrenci Kimlik Bilgileri ****");
Console.WriteLine();

Console.Write("Adınız: ");
ad = Console.ReadLine();

Console.Write("Soyadınız: ");
soyad = Console.ReadLine();

Console.Write("Numara: ");
numara = Console.ReadLine();

Console.WriteLine("**** Öğrenci Sınav Bilgileri ****");
Console.WriteLine();

Console.Write("Birinci sınav: ");
sinav1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sayı: ");
sinav2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Üçüncü sınav: ");
sinav3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Proje notunuz: ");
proje = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("**** Ortalama Değeri ****");
Console.WriteLine();

ort = (sinav1+ sinav2+ sinav3+proje) / 4;
Console.Write("Ad soyad: " + ad + soyad);
Console.WriteLine("Ortalama: " + ort);
Console.Read();