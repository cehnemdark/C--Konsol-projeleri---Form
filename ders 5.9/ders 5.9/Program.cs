//decimal sayi;
//sayi = 12.345m;
//Console.WriteLine(sayi);

//****************************

//decimal s1;
//int s2;
//s1 = 2.4M;
//s2 = 4;

//decimal toplam;
//toplam = s1 + s2;
//Console.WriteLine("Toplam: "+toplam);

//****************************

//decimal x = 0.996m;
//decimal y = 9999999;
//Console.WriteLine("Para 1: {0:C}", x);
//Console.WriteLine("Para 2: {0: C}", y);
//Console.WriteLine("X: " + x);
//Console.WriteLine("Y: " + y);

//****************************

decimal urun1, urun2, toplam;
int s1, s2;
urun1 = 14.85M;
urun2 = 21.48M;
Console.WriteLine("1. ürünün satış miktarı: ");
s1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("2. ürünün satış miktarı: ");
s2 = Convert.ToInt16(Console.ReadLine());
toplam = s1 * urun1 + s2 * urun2;
Console.WriteLine("Gün sonunda kasada olması gereken tutar: " + toplam + "TL'dir");