//int i = 1;
//for (i = 1;  i<=10; i++)   
//{
//    Console.WriteLine("Merhaba Eskişehir");
//}
//Console.ReadLine();


// ***********************************************

//int i;
//i = 1;
//while (i < 10)
//{
//    Console.WriteLine("Merhaba Çanakkale");
//    i++;
//}
//Console.ReadLine();

// ***********************************************

//int i = 1;
//while (i <= 1000)
//{
//    Console.WriteLine(i);
//    i++;
//}

// ***********************************************
//int sayi;
//Console.WriteLine("Bir sayı girin: ");
//sayi = Convert.ToInt16(Console.ReadLine());

//while (sayi % 2 == 0)
//{
//    Console.WriteLine("Bir sayı girin: ");
//    sayi = Convert.ToInt16(Console.ReadLine());
//}
//Console.WriteLine("Tek sayı girdiniz.");

/*  kullanıcıdan bir sayı girmesini isteyen ve girilen
    sayı tek bir sayı olana kadar devam eden bir döngü
    içeren bir programdır. */

/*  while (sayi % 2 == 0) ile girilen sayının çift olup
    olmadığı kontrol edilir. Eğer sayı çiftse (yani sayının
    2'ye bölümünden kalan 0'sa), döngü devam eder.
*/

// ***********************************************

int sayi;
Console.WriteLine("Faktöriyeli alınacak sayıyı girin: ");
sayi = Convert.ToInt16(Console.ReadLine());
int faktoryel = 1;

while (sayi > 1)
{
    faktoryel = faktoryel * sayi;
    sayi--;
}
Console.WriteLine(faktoryel);