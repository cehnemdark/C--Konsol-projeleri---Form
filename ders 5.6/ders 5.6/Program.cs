//char harf;
//harf = 'G';
//Console.WriteLine(harf);

//*****************************
// strin ile
//string harfler = "GECIKME";
//Console.WriteLine(harfler); // GECIKME
//**************************************

// char tipinde ama dizi ile

//char[] harfler = { 'G', 'E', 'C', 'I', 'K', 'M', 'E' };
//Console.WriteLine(harfler); // GECIKME

//**********************************************

//char cinsiyet;
//Console.Write("Cinsiyeti girin: ");
//cinsiyet = Convert.ToChar(Console.ReadLine());
//if (cinsiyet == 'e' || cinsiyet == 'E')
//{
//    Console.WriteLine("Cinsiyet erkektir");
//}else
//{
//    Console.WriteLine("Cinsiyet kadındır");
//}
//**********************************************

char ders;
Console.WriteLine(".... YGS Dersleri Menüsü ....\n");
Console.WriteLine("Türkçe...");
Console.WriteLine("Matematik...");
Console.WriteLine("Sosyal Bilgisi...");
Console.WriteLine("Fen Bilgisi...\n");
Console.Write("Hangi dersin bilgilerini görmek istersiniz: ");

ders = Convert.ToChar(Console.ReadLine());

if (ders == 't' || ders == 'T')
{
    Console.WriteLine("Türkçe dersi paragraf ağırlıklı olup dil bilgisi sorularıda içerir.");
}else if (ders == 'm' || ders == 'M')
{
    Console.WriteLine("Matematik dersi temel mat1 konuları ve 8, 9 tane geometri dersi içerir.");
}else if (ders == 's' || ders == 'S')
{
    Console.WriteLine("Sosyal bilgiler dersi tarih vef coğrafya konularını içerir.");
}else
{
    Console.WriteLine("Fen bilgisi, fizik, kimya ve biyoloji konularını içerir.");
}
 