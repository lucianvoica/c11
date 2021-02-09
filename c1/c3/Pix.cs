using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3
{
    public class Pix
    {
        public bool EsteDeschis { get; set; }
        public string Culoare { get; set; }
        public string CuloarePasta { get; set; }
        public Pix()
        {
            EsteDeschis = false;
            Culoare = "alb";
            CuloarePasta = "albastru";
        }
        public void DeschidePix()
        {
            EsteDeschis = true;
        }
        public void Scrie(string mesaj)
        {
            if (EsteDeschis)
            {
                Console.WriteLine(CuloarePasta + ": " + mesaj);
            }
        }
        public void InchidePix()
        {
            EsteDeschis = false;
        }
    }
}
