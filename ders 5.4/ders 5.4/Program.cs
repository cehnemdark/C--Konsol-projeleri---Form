//int[] sayilar = { 4, 1, 7, -8, 23, 14, 51, 84, -75, 26, -8, 9 };
//foreach (int i in sayilar)
//{
//    if (i > 0 && i % 2 == 1)
//    {
//        Console.WriteLine(i);
//    }
//}

// ******************************************

// 10 ve 30 arasındaki çift sayıları bulan program

//int[] sayilar = { 4, 1, 7, -8, 23, 14, 51, 84, -75, 26, -8, 9 };
//foreach (int i in sayilar)
//{
//    if (i >= 10 && i <= 30 && i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}
// ******************************************

//int[] sayilar = new int[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.Write("Sayıyı girin: ");
//    sayilar[i] = Convert.ToInt32(Console.ReadLine());   
//}

//Array.Sort(sayilar);


//Console.WriteLine("En küçük eleman: " + sayilar[0]);
//Console.WriteLine("En büyük eleman: " + sayilar[4]);
//Console.WriteLine("Dizinin boyutu: " + sayilar.Length);
// *****************************************************

/* Aynı örnek fakat bu kez dizinin en büyük elemanını
 * dizide eleman sayısı yoksa bulan program */

int[] sayilar = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Sayıyı girin: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

int enBuyuk = sayilar[0];

for (int i = 1; i < sayilar.Length; i++)
{
    if (sayilar[i] > enBuyuk)
    {
        enBuyuk = sayilar[i];
    }
}

Console.WriteLine("En küçük eleman: " + sayilar[0]);
Console.WriteLine("En büyük eleman: " + enBuyuk);
Console.WriteLine("Dizinin boyutu: " + sayilar.Length);


