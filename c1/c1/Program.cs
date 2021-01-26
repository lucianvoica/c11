using System;

namespace c1
{
    class Program
    {
        static void Main(string[] args)
        {
            //voi face un program de inceput

            /* acesta este
               un comentariu
               pe mai multe linii */
            string Mesaj = "prima valoare";
            
            string mesaj;
            mesaj = "a doua valoare";

            sbyte signedByte = 127;
            byte Byte = 34;

            char caracter = 'd';
            short Short = 4584;

            float a = 3.5F;
            float b = 35;

            double c = 3.5;
            double d = 3D;

            decimal e = 3.5M;

            //citim de la tastatura un mesaj
            string mesajDeLaTastatura = Console.ReadLine();

            int numar1 = int.Parse(mesajDeLaTastatura);

            Console.WriteLine(numar1 * numar1);

            int x = 0;
            int y = 1;

            //x = y++; // x = y; y = y + 1; -> x = 1 , y = 2;

            //x = ++y; // y = y + 1; x = y; -> x = 2 , y = 2; 

            x = 5;
            y = 2;
            /* x += y; // x = x + y;  --> x = 7, y = 2
            x -= y; // x = x - y;
            x /= y; // x = x / y;  --> x = 2, y = 2 */
            x %= y; // x = x % y;  --> x = 1, y = 2;
            x *= y; // x = x * y;

            string textCompus = "Text" + "Doi"; //TextDoi

            x += y; // x = x + y;

            short variabila = 34;

            Console.ReadKey();
        }
    }
}
