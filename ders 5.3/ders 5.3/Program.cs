//string[] sehirler = { "Mersin", "İzmir", "Kocaeli", "Artvin", "Ankara", "Şanlıurfa" };

//foreach (string s in sehirler)
//{
//    Console.WriteLine(s);
//}
//*******************************************

//int[] sayilar = { 1, 4, 8, 52, 41, 75, 126, 85, 24 };
//foreach (int i in sayilar)
//{
//    Console.WriteLine(i);
//}
//*******************************************

//int[] sayilar = { 1, 4, 8, 9, 6 };
//int toplam = 0;
//foreach (int i in sayilar)
//{
//    toplam = toplam + i;
//}
//Console.WriteLine("Toplam: "+toplam);

// ***********************************************

//int[] rakamlar = { 1, 7, 5, 4, 8, 6, 9, 3 };
//foreach (int sayi in rakamlar)
//{
//    if (sayi % 2 == 0)
//    {
//        Console.WriteLine(sayi);
//    }
//}

//*******************************************************

int[] degerler = { 1, 2, 3, 4, 5, 6, 7};
int sonuc = 1;
foreach (int i in degerler)
{
    sonuc = sonuc * i;
}
Console.WriteLine("6 sayısının faktöryeli: "+sonuc);
