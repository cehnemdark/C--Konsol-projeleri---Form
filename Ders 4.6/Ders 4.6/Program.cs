// Klavyeden girilen sayıya göre haftanın ilgili gününü veren program

//int sayi;
//Console.WriteLine("1 ile 7 arasında bir sayı giriniz: ");
//sayi = Convert.ToInt16(Console.ReadLine());

//switch (sayi)
//{
//    case 1: Console.WriteLine("Gün = Pazartesi");
//        break;
//    case 2: Console.WriteLine("Gün = Salı");
//        break;
//    case 3: Console.WriteLine("Gün = Çarşamba");
//        break;
//    case 4: Console.WriteLine("Gün = Perşembe");
//        break;
//    case 5: Console.WriteLine("Gün = Cuma");
//        break;
//    case 6: Console.WriteLine("Gün = Cumartesi");
//        break;
//    case 7: Console.WriteLine("Gün = Pazartesi");
//        break;
//    default: Console.WriteLine("Hatalı gün girişi");
//        break;

//}
//*************************************************************

// Kullanıcı girmiş olduğu mevsime göre o mevsimin aylarını getiren program

//string mevsim;
//Console.WriteLine("Lütfen mevsimi küçük harflerle giriniz: ");
//mevsim = Console.ReadLine();

//    switch (mevsim)
//{
//    case "yaz": Console.WriteLine("Yaz mevsimi: Haziran, Temmuz, Ağustos");
//        break;
//    case "sonbahar": Console.WriteLine("Sonbahar mevsimi ayları: Eylül, Ekim, Kasım");
//        break;
//    case "kış": Console.WriteLine("Kış mevsimi ayları: Aralık, Ocak, Şubat");
//        break;
//    case "ilkbahar": Console.WriteLine("İlkbahar mevsimi ayları: Mart, Nisan, Mayıs");
//        break;
//        default: Console.WriteLine("Hatalı mevsim girişi");
//        break;
//}
//Console.ReadLine();
//*****************************************************************************************

// İstabul iline 8 tane şehrin kaç kilometre uzakta olduğunu switchcase kullanarak kullanıcıya yazdıran program

string sehir;
Console.WriteLine("Lütfen şehri giriniz: ");
sehir = Console.ReadLine();

switch (sehir)
{
    case "adana": Console.WriteLine("İstanbul ilinin Adana'ya uzaklığı 939 km'dir. ");
        break;
    case "ankara":
    case "Ankara":
        Console.WriteLine("İstanbul ilinin Ankara'ya uzaklığı 453 km'dir");
        break;
    case "antalya":
        Console.WriteLine("İstanbul ilinin Antalya'ya uzaklığı 724 km'dir");
        break;
    case "bursa":
         Console.WriteLine("İstanbul ilinin Bursa'ya uzaklığı 243 km'dir");
        break;
    case "elazığ":
        Console.WriteLine("İstabul ilinin Elazığ'a uzaklığı 1212 km'dir");
        break;
    case "izmir":
        Console.WriteLine("İstabul ilinin İzmir'e uzaklığı 561 km'dir");
        break;
    case "malatya":
        Console.WriteLine("İstanbul ilinin Malatya'ya uzaklığı 1114 km'dir");
        break;
    case "trabzon":
        Console.WriteLine("İstabul ilinin Trabzon'a uzaklığı 1070 km'dir");
        break;
        default: Console.WriteLine("Bu şehir hafızada mevcut değil :(");
        break;
}
Console.ReadLine();