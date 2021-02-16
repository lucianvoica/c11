using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4
{
    public class Student : Persoana
    {
        public string Facultate { get; set; }
        public float Medie { get; set; }
        public Student(string nume, 
            string prenume, 
            int varsta,
            string facultate, 
            float medie) : base(nume, prenume, varsta)
        {
            Console.WriteLine("constructor student");
            Facultate = facultate;
            Medie = medie;
        }

        public void PrinteazaInformatiiComplete()
        {
            //string mesaj = "Studentul " + Nume + " " + Prenume;
            string mesaj = string.Format(@"Studentul {0} {1}, cnp {2}, cu varsta de {3} ani, 
este student al facultatii {4}, avand media {5}, cu grupa {6}",
                                         Nume, 
                                         Prenume, 
                                         Cnp, 
                                         Varsta, 
                                         Facultate, 
                                         Medie,
                                         GetGrupa());
            Console.WriteLine(mesaj);
        }
    }
}
