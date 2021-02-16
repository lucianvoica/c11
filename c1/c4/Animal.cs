using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4
{
    public class Animal
    {
        public int Picioare { get; set; }
    }

    public class Pisica : Animal
    {
        public string Personalitate { get; set; }
    }

    public class Caine : Animal
    {

    }

    public class Birmaneza : Pisica
    {

    }

    public class Persana : Pisica
    {

    }

    public class Maidanez : Caine
    {

    }

    public class Pitbull : Caine
    {

    }

}
