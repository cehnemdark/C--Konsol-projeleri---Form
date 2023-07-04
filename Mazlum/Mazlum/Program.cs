using System;

class MainClass
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan; // Yazı rengi
        Console.BackgroundColor = ConsoleColor.Magenta; // Arkaplan rengi
        Console.Clear(); // Konsolu temizle

        Console.WriteLine(@"                                                      
 .x88k 888     d8b                                   
o*8888 888     Y8P                                   
   888 888                                             
   888 888 .d88b.  888d888 .d8888b 88888b.d88b.   .d88b.
   888 888d8P  Y8b 888P'  d88P'    888 '888 '88b d88'''''
   888 88888888888 888    888      888  888  888 888     
   88P 888 Y8b.     888    Y88b.    888  888  888 Y88b.   
   *8t 888  *Y8888  888     'Y8888P 888  888  888  'Y8888P


");

        Console.WriteLine();

        Console.WriteLine("MAZLUM");

        Console.ResetColor(); // Renkleri sıfırla
    }
}
