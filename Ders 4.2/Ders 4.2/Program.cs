int sayi1, sayi2, toplam, fark, carpim, bolum;
Console.WriteLine("**** Aritmetik 4 İşlem ****");
Console.WriteLine();

Console.Write("1'inci sayıyı girin: ");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2'nci sayıyı girin: ");
sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

toplam = sayi1 + sayi2;
Console.WriteLine("Toplam: "+toplam);

fark = sayi1 - sayi2;
Console.WriteLine("Fark: " + fark);

carpim = sayi1 * sayi2;
Console.WriteLine("Çarpım: "+carpim);

bolum = sayi1 / sayi2;
Console.WriteLine("Bölüm = " + bolum);
Console.ReadLine();
