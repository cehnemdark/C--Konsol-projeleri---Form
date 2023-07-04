//string[] isimler = { "ali", "ahmet", "ayşe", "emel", "baran", "akın"};
//Console.WriteLine(isimler[6]);
//*********************************


string[] sehirler = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.Write("Şehir: ");
    sehirler[i] = Console.ReadLine();
}
Console.WriteLine("**** Şehirler Listesi ****");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(sehirler[i]);
}
