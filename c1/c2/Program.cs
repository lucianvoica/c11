using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2
{
    class Program
    {
        enum ZileSaptamana
        {
            Luni = 1,
            Marti,
            Miercuri,
            Joi,
            Vineri,
            Sambata,
            Duminica
        }

        static void Main(string[] args)
        {
            //Console.Write("Introduceti numarul: ");
            //string mesajDeLaTastatura = Console.ReadLine();
            //int numar = int.Parse(mesajDeLaTastatura);

            //if(numar >= 10)
            //{
            //    Console.WriteLine("numarul este >= 10");
            //} 
            //else
            //{
            //    Console.WriteLine("numarul este < 10");
            //}
            int i;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.WriteLine(i); // 3

            for (i = 3; i < 10; i = i + 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            int nr = 3;
            while (nr < 10)
            {
                Console.Write(nr + " ");

                nr += 2;
            }

            Console.WriteLine();

            nr = 3;
            do
            {
                Console.Write(nr + " ");

                nr += 2;
            } while (nr < 10);

            const double PI = 3.141592;


            Console.Write("Introduceti ziua saptamanii: ");
            string mesajDeLaTastatura = Console.ReadLine();
            int numar = int.Parse(mesajDeLaTastatura);


            if (numar == (int)ZileSaptamana.Luni)
            {
                Console.WriteLine("Laeroi");
            }
            else if (numar == (int)ZileSaptamana.Marti)
            {
                Console.WriteLine("lsdjfdsj");
            }
            else if (numar == (int)ZileSaptamana.Miercuri)
            {
                Console.WriteLine("ggfg");
            }
            else if (numar == (int)ZileSaptamana.Joi)
            {
                Console.WriteLine("gfgfgf");
            }

            switch (numar)
            {
                case (int)ZileSaptamana.Luni:
                case (int)ZileSaptamana.Marti:
                    Console.WriteLine("test");
                    break;
                case (int)ZileSaptamana.Miercuri:
                    Console.WriteLine("ggfg");
                    break;
                case (int)ZileSaptamana.Joi:
                    Console.WriteLine("gfgfgf");
                    break;
            }

            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    break;
                }
                Console.Write(j + " ");
            }
            Console.WriteLine("final");  // 0 1 2 3 4 final


            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    continue;
                }

                Console.Write(j + " ");
            }
            Console.WriteLine("final");  // 0 1 2 3 4 6 7 8 9 final

            mesajDeLaTastatura = Console.ReadLine();
            int n = int.Parse(mesajDeLaTastatura);
            int z, p, c;
            z = 0;
            p = 1;
            while(n > 0)
            {
                c = n % 10;
                n = n / 10;
                if(c % 3 == 0)
                {
                    z = z + p * (9 - c);
                    p = p * 10;
                }
            }
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
