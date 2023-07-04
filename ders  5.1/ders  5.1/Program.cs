//int[] sayilar = new int[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.Write((i + 1).ToString() + ".Sayıyı girin: ");
//    sayilar[i] = Convert.ToInt32(Console.ReadLine());

//}

//int enbuyuk;
//enbuyuk = sayilar[0];

//for (int i = 1; i < 5; i++)
//{
//    if (enbuyuk < sayilar[i])
//    {
//        enbuyuk = sayilar[i];
//    }
//}
//Console.WriteLine(enbuyuk);

//*******************************************************

string[] isimler = new string[3];
int[] s1Notlari = new int[3];
int[] s2Notlari = new int[3];
int[] ortalamaNotlar = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Clear();

    Console.Write((i + 1) + ". Öğrencinin Adı: "); 
    isimler[i] = Console.ReadLine();

    Console.Write((i + 1) + ". Sınav1: ");
    s1Notlari[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write((i + 1) + ". Sınav2: ");
    s2Notlari[i] = Convert.ToInt32(Console.ReadLine());

    ortalamaNotlar[i] = (s1Notlari[i] + s2Notlari[i]) / 2;
}

Console.WriteLine("Öğrenci | Sınav1 | Sınav2 | Ortalama");
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{isimler[i],-8} | {s1Notlari[i],-6} | {s2Notlari[i],-6} | {ortalamaNotlar[i],-8}");
}
