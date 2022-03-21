using System;

namespace Practica4MAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bye();
            WhatsUp();

            //Modificacion de archivos diferentes en las copias locales
        }

        static void Bye()
        {
            Console.WriteLine("Goodbye World!");
        }

        static void WhatsUp()
        {
            Console.WriteLine("Hey, what's up?");
        }
    }
}
