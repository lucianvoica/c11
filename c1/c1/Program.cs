using System;

namespace c1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////voi face un program de inceput

            ///* acesta este
            //   un comentariu
            //   pe mai multe linii */
            //string Mesaj = "prima valoare";

            //string mesaj;
            //mesaj = "a doua valoare";

            //sbyte signedByte = 127;
            //byte Byte = 34;

            //char caracter = 'd';
            //short Short = 4584;

            //float a = 3.5F;
            //float b = 35;

            //double c = 3.5;
            //double d = 3D;

            //decimal e = 3.5M;

            ////citim de la tastatura un mesaj
            //string mesajDeLaTastatura = Console.ReadLine();

            //int numar1 = int.Parse(mesajDeLaTastatura);

            //Console.WriteLine(numar1 * numar1);

            //int x = 0;
            //int y = 1;

            ////x = y++; // x = y; y = y + 1; -> x = 1 , y = 2;

            ////x = ++y; // y = y + 1; x = y; -> x = 2 , y = 2; 

            //x = 5;
            //y = 2;
            ///* x += y; // x = x + y;  --> x = 7, y = 2
            //x -= y; // x = x - y;
            //x /= y; // x = x / y;  --> x = 2, y = 2 */
            //x %= y; // x = x % y;  --> x = 1, y = 2;
            //x *= y; // x = x * y;

            //string textCompus = "Text" + "Doi"; //TextDoi

            //x += y; // x = x + y;

            //short variabila = 34;

            //int a = 10;

            //bool rezultat = (a != 10);

            //bool a = false;
            //bool b = true;
            //bool c = true;
            //bool rezultat;

            //rezultat = !b ;

            //double d = 34.23;
            //int i;

            //i = (int) d;

            //short a = 32650;
            //short b = 32650;
            ////a + b = 65300;

            //string rezultat = (a + b).ToString(); // -236


            //int a = 4;
            //float b = 4.4F;
            //decimal c = 4.4M;
            //double d = 4.4;

            //Console.WriteLine(b.ToString());

            //int e = -23;

            //Console.WriteLine(Convert.ToBoolean(e));
            //// true daca e != 0
            //// false daca e == 0

            if (1 == 2 && false) //expresie care sa fie evaluata la bool
            {
                Console.WriteLine("rezultatul este adevarat");
            }
            else if (3 == 4)
            {
                Console.WriteLine("rezultatul 2 este adevarat");
            }
            else
            {
                Console.WriteLine("rezultatele 1 si 2 sunt false");
            }



            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
