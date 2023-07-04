using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.BackgroundColor = ConsoleColor.DarkRed;
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.Title = "3 Temmuz 2023";
             Console.Clear();

             Console.WriteLine("12 Eylül Rojava Devrimi"); */
            // ***************************************************

            /* Bu kod, kullanıcının bir sayı girmesini isteyen ve ardından girilen sayıya karşılık gelen
             * bir renk kodunu alarak arka plan rengini değiştiren bir C# konsol uygulamasıdır. */

            // *****************************************************************
            Console.WriteLine("Lütfen bir sayı girin: ");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
            Console.BackgroundColor = renk;
            Console.Clear();
            Console.ReadLine();

        }
    }
}
