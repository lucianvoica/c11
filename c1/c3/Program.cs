using System;
namespace c3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Student s1;

            //2
            Student s2;
            s2 = new Student();

            //3
            s1 = new Student();

            //4
            Elev e1 = new Elev();

            Persoana p3 = new Persoana();
            p3.adresa = "Bucuresti";

            //p3.SetNumeSiPrenume("Voica", "Lucian");
            //p3.SetNumeSiPrenume(prenume: "Lucian", nume: "Voica");

            Persoana p4 = new Persoana();

            //p4.SchimbaNumePrenumeCNP("NUME", "PRENUME", "1000");

            //p4.PrintNumeComplet();

            Persoana pers1 = new Persoana();
            //pers1.SetNume("DO_IT_ACADEMY");
            //pers1.SetPrenume("Cursant");
            //pers1.SetVarsta(20);

            //Console.WriteLine(pers1.GetNume() + " " 
            //    + pers1.GetPrenume() + " " 
            //    + pers1.GetVarsta());

            pers1.Nume = "DO_IT_ACADEMY";
            pers1.Prenume = "Cursant";


            Console.WriteLine(pers1.Nume + " " + pers1.Prenume);

            //string numeCompletP4 = p4.GetNumeComplet();
            Console.WriteLine(numeCompletP4);

            Console.ReadKey();
        }
    }
}
