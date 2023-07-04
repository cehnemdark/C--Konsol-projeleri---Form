int kenar, karealan, karecevre;
int kisakenar, uzunkenar, dikalan, dikcevre;

Console.WriteLine("**** Karenin alan ve çevresini bulma ****");
Console.WriteLine("Karenin bir kenarını girin: ");
kenar = Convert.ToInt32(Console.ReadLine());
karealan = kenar * kenar;
karecevre = kenar * 4;
Console.WriteLine();
Console.WriteLine("Kare alan: " + karealan);
Console.WriteLine("Kare çevre " + karecevre);
Console.WriteLine();
Console.WriteLine("**** Dikdörtgenin alan ve çevresini bulma ****");
Console.WriteLine();

Console.Write("Kısa kenarı girin: ");
kisakenar = Convert.ToInt32(Console.ReadLine());
Console.Write("Uzun kenarı girin: ");
uzunkenar = Convert.ToInt32(Console.ReadLine());
dikalan = kisakenar * uzunkenar;
dikcevre = kisakenar * 2 + uzunkenar *2;
Console.WriteLine();

Console.WriteLine("Diktörgen alan: " + dikalan);
Console.WriteLine("Dökdörtgen çevre: "+dikcevre);

Console.ReadLine();