using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Persoana persoana = new Persoana();
            ////Persoana persoana1 = new Persoana("Popescu", "Ion");
            ////Persoana persoana2 = new Persoana("Ion", true);
            //Persoana pers1 = new Persoana("NumeA", "PrenumeA", 21);
            //Persoana pers3 = new Persoana("PrenumeA", "NumeA", 21);
            //Persoana pers2 = new Persoana(prenume: "PrenumeA", nume: "NumeA", varsta: 21);

            ////Console.WriteLine(persoana.Nume + " " + persoana.Prenume);

            ////Console.WriteLine(persoana1.Nume + " " + persoana1.Prenume);

            //Persoana.esteOm = false;

            ////ConvertorValutar convertorValutar = new ConvertorValutar();
            ////double rezultat = convertorValutar.ConvertEurToRon(10);

            ////ConvertorValutar convertorValutar1 = new ConvertorValutar();
            ////double rezultat1 = convertorValutar1.ConvertEurToRon(10);

            //double rezultat = ConvertorTemperatura.ConvertCToF(32);

            //Console.WriteLine(rezultat);

            //Console.WriteLine(rezultat1);

            //Student stud1 = new Student();
            //stud1.Nume = "Popescu";
            //stud1.Prenume = "Ion";
            //stud1.Facultate = "Unibuc";
            //stud1.Adresa = "Bucuresti";
            //stud1.Medie = 9.7F;
            //stud1.Varsta = 20;
            //stud1.Cnp = "adsasd";

            //Student stud2 = new Student("Unibuc", 9.7F);

            //Persoana persoana = new Persoana();
            //Student student = new Student("", "", 18, "", 2);

            //string mesaj = student.ToString();
            //Console.WriteLine(mesaj);

            //student.PrinteazaInformatiiComplete();

            //Animal animal = new Animal();
            //Animal p1 = new Pisica();
            //p1 = new Birmaneza();

            //Pisica p2 = new Pisica();
            //p2 = new Birmaneza();

            Persoana p1 = new Student("", "", 18, "ASD", 2);
            Persoana p2 = new ElevLiceu("", "", 18, "", 2);

            Student p3 = new Student("", "", 18, "PRR", 2);

            p3 = (Student)p1;

            Console.WriteLine(p3.Facultate);

            Console.ReadKey();  
        }
    }
}
