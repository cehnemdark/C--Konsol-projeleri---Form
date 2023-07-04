//int sayi1, sayi2, toplam;
//sayi1 = 5;
//sayi2 = 7;
//toplam = sayi1 + sayi2;
//Console.WriteLine(toplam);
// *************************************


//int a, b, c;
//a = 8;
//b = 7;
//c = a * b;
//Console.WriteLine("a * b = " + c);
//Console.Read();

// *************************************

//int a, b, c;
//Console.Write("İlk sayıyı girin: ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("İkinci sayıyı girin: ");
//b = Convert.ToInt32(Console.ReadLine());

//c = a * b;

//Console.WriteLine("İlk sayı: {0}, ikinci sayı: {1}, sonuç: {2}", a, b, c);

// *************************************

//int deger1, deger2, bolum;
//deger1 = 12;
//deger2 = 22;
//bolum = (deger1 + deger2) / 2;
//Console.WriteLine(bolum);

// *************************************

string ad, soyad, numara;
int sinav1, sinav2, sinav3, proje, ortalama;
Console.WriteLine("**** Öğrenci Bilgi ****");

ad = "Serhad";
soyad = "Güneş";
numara = "46846646";
Console.WriteLine("Ad: "+ad);
Console.WriteLine("Soyad: "+soyad);
Console.WriteLine("Numara: "+numara);

Console.WriteLine();
Console.WriteLine("**** Not Bilgi ****");
Console.WriteLine();

sinav1 = 60;
sinav2 = 70;
sinav3 = 100;
proje = 94;

Console.WriteLine("Sınav 1 = "+ sinav1);    
Console.WriteLine("Sınav 2 = " + sinav2);
Console.WriteLine("Sınav 3 = " + sinav3);
Console.WriteLine("Proje Notu = "+ proje);
Console.WriteLine();
Console.WriteLine("**** Ortalama Bilgi ****");
Console.WriteLine();


ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
Console.WriteLine("Ortalama: " + ortalama);


Console.Read();