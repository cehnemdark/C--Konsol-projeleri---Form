// Döngüler, ilk örnek
//int i;
//for (i = 1; i<=10; i++)
//{
//    Console.WriteLine("Merhaba Dünya");
//}
//Console.ReadLine();

// İkinci örnek

//int i;
//for (i=1; i<=10; i++)
//{ 
//    Console.WriteLine(i);
//}
//Console.ReadLine(); 

// Örnek 3

//int j;
//for (j=0; j <= 20; j+=3) 
//{
//    Console.WriteLine(j);

//}

// Örnek 4

int i;
int toplam = 0;

for (i = 1; i <= 10; i+=2)
{
    toplam = toplam + i;
}
Console.WriteLine("Toplam = "+toplam);
Console.ReadLine();

// 0 yazılırsa = 0, 2, 4, 6, 8, 10 = 30
// 1 yazılırsa = 1, 3, 5, 7, 9 = 25 