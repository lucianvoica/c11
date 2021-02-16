using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4
{
    public class Persoana
    {
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Prenume { get; set; }
        public bool EsteBarbat { get; set; }
        protected string Cnp { get; set; }
        public string Adresa { get; set; }

        private string GrupaSanguina;
        //public Persoana()
        //{
        //    Console.WriteLine("constructor persoana");
        //    Nume = "Default";
        //    Varsta = 18;
        //    Prenume = "Prenume";
        //    EsteBarbat = true;
        //    Cnp = "12387123";
        //    Adresa = "-";
        //}
        protected string GetGrupa()
        {
            return this.GrupaSanguina;
        }
        public Persoana(string nume, string prenume, int varsta)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            EsteBarbat = true;
            Cnp = "12387123";
            Adresa = "-";
        }

        public Persoana(string prenume, bool esteBarbat)
        {
            Nume = "Default";
            Prenume = prenume;
            Varsta = 18;
            EsteBarbat = esteBarbat;
            Cnp = "12387123";
            Adresa = "-";
        }

        //~Persoana()
        //{
        //    Console.WriteLine("destructorul clasei Persoana a fost apelat");
        //}
    }
}
