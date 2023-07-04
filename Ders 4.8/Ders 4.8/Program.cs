using System;

class Program
{
    static void Main(string[] args)
    {
        // 1'den 100'e kadar olan sayılardan 9'a tam bölünenleri yazdırma
        for (int i = 1; i <= 100; i++)
        {
            if (i % 9 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("\n---\n");

        // 120 sayısının tam bölenlerini bulma
        int sayi = 120;
        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("\n---\n");

        // Fibonacci serisini yazdırma
        int a = 1;
        int b = 1;
        int c;

        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 1; i <= 8; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine(c);
        }
    }
}
