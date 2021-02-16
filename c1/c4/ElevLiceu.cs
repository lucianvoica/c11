using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4
{
    public class ElevLiceu : Persoana
    {
        public string Liceu { get; set; }
        public float MedieCapacitate { get; set; }

        public ElevLiceu(string nume, string prenume, int varsta, 
            string liceu, float medieCapacitate) : base(nume, prenume, varsta)
        {
            Liceu = liceu;
            MedieCapacitate = medieCapacitate;
        }
    }
}
