using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_6._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* byte sayi;
             sayi = 255;
             Console.WriteLine(sayi); */

            //********************************

            /* byte s1, s2;
            s1 = 20;
            s2 = 240;
            Console.WriteLine(s1 + s2); */

            //********************************

            /* sbyte deger;
             deger = 5;
             Console.WriteLine(deger); */

            /* Console.WriteLine("**** Doğu Anadolu Bölgesi Hava Durumu ****");
            Console.WriteLine("1-Ocak 2023 Hava Tahminleri");
            sbyte Erzurum, Malatya, Elazig;
            Erzurum = -35;
            Malatya = 3;
            Elazig = - 7;

            Console.WriteLine("Erzurum Karlı: "+ Erzurum + " derecedir");

            Console.WriteLine("Malatya çok bulutlu: " + Malatya + " derecedir");
            Console.WriteLine("Elazığ karla karışık yağmurlu: " + Elazig + " derecedir"); */

            //*******************************
            //short s1, s2, s3;
            //s1 = 32767;
            //s2 = -32767;
            //s3 = -32768;
            //Console.WriteLine(s1 + s2 + s3);
            //*******************************

            ushort s1, s2;
            s1 = 0;
            s2 = 65535;
            Console.WriteLine(s1 + s2);

            Console.Read();
        }   
    }
}
