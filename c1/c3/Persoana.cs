using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3
{
    class Persoana
    {
        private bool esteBarbat;
        private string cnp;
        public string adresa;

        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Prenume { get; set; }

        public int PinCard { get; set; }

        public bool EsteBarbat
        {
            get
            {
                return this.esteBarbat;
            }
            set
            {
                this.esteBarbat = value;
            }
        }

        public string Cnp
        {
            get
            {
                return this.cnp;
            }
            set
            {
                this.cnp = value;
            }
        }

        //public string GetNume()
        //{
        //    return this.nume;
        //}
        //public void SetNume(string nume)
        //{
        //    this.nume = nume;
        //}
        //public string GetPrenume()
        //{
        //    return this.prenume;
        //}
        //public void SetPrenume(string noulPrenume)
        //{
        //    this.prenume = noulPrenume;
        //}
        //public int GetVarsta()
        //{
        //    return varsta;
        //}
        //public void SetVarsta(int varsta)
        //{
        //    this.varsta = varsta;
        //}

        //public void SetNumeSiPrenume(string nume, string prenume = "prenume default")
        //{
        //    this.prenume = prenume;
        //    this.nume = nume;
        //}

        //public void PrintNume()
        //{
        //    Console.WriteLine(nume);
        //}

        //public void PrintNumeComplet()
        //{
        //    string rezultat = GetNumeComplet();
        //    Console.WriteLine(rezultat);
        //}

        //public string GetNumeComplet()
        //{
        //    return prenume + " " + nume;
        //}

        //public void SchimbaPrenumele(string prenumeNou)
        //{
        //    prenume = prenumeNou;
        //}

        //public void SchimbaNumePrenumeCNP(
        //    string noulNume, 
        //    string noulPrenume = "PRENUME", 
        //    string noulCnp = "CNP")
        //{
        //    nume = noulNume;
        //    prenume = noulPrenume;
        //    cnp = noulCnp;
        //}

    }
}
