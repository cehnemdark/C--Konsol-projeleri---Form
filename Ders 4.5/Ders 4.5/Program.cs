// Klavyeden girilen mevsime göre o mevsimin aylarını yazdıran program
//string mevsim;
//Console.WriteLine("Lütfen bir mevsim giriniz: ");
//mevsim = Console.ReadLine();

//if (mevsim == "kış" || mevsim == "Kış")
//{
//    Console.WriteLine("Kış mevsimi ayları: Aralık, Ocak, Şubat");
//}
//else if (mevsim == "ilkbahar" || mevsim == "İlkbahar")
//{
//    Console.WriteLine("İlkbahar mevsimi ayları: Mart, Nisan, Mayıs");
//}
//else if (mevsim == "yaz" || mevsim == "Yaz")
//{
//    Console.WriteLine("Yaz mevsimi ayları: Haziran, Temmuz, Ağustos");
//}
//else if (mevsim == "sonbahar" || mevsim == "Sonbahar")
//{
//    Console.WriteLine("Sonbahar mevsimi ayları: Eylül, Ekim, Kasım");
//}
//else
//{
//    Console.WriteLine("Geçersiz mevsim girdiniz.");
//}



// C# konsol uygulamalarında if/else yapısının kullanımını açıklamaktadır. İki farklı örnek üzerinden konu işlenmektedir.

// Öne çıkanlar
// 🎯 İlk örnek Klavyeden girilen mevsime göre o mevsimin aylarını yazdıran bir program.
// 📚 İkinci örnek Bir kitapçının müşterilerine uyguladığı indirimi hesaplayan bir uygulama.
//*******************************************************************************************

// Ali amcanın dükkanından kitap alan kişilerin ödemesi gereken fiyat tutarını bulan program
Console.WriteLine("**** Ali Amcanın Kitapçı Dükkanı ****");
double x, indirim, indirimliFiyat, indirimMiktari;
Console.WriteLine("Alışveriş tutarını girin: ");
x = Convert.ToDouble(Console.ReadLine());

if (x < 100)
{
    indirim = x * 10 / 100;
    indirimliFiyat = x - indirim;
    indirimMiktari = indirim;
    Console.WriteLine("Indirim Miktarı: " + indirimMiktari);
    Console.WriteLine("Toplam Miktar: " + indirimliFiyat);
}
else if (x >= 100 && x < 150)
{
    indirim = x * 15 / 100;
    indirimliFiyat = x - indirim;
    indirimMiktari = indirim;
    Console.WriteLine("Indirim Miktarı: " + indirimMiktari);
    Console.WriteLine("Toplam Miktar: " + indirimliFiyat);
}
else if (x >= 150 && x <= 200)
{
    indirim = x * 20 / 100;
    indirimliFiyat = x - indirim;
    indirimMiktari = indirim;
    Console.WriteLine("Indirim Miktarı: " + indirimMiktari);
    Console.WriteLine("Toplam Miktar: " + indirimliFiyat);
}

Console.ReadLine(); 