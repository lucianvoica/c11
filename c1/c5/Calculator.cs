using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c5
{
    public class Calculator
    {

        public int CalculeazaSuma(int a, int b)
        {
            return a + b;
        }

        public string CalculeazaSuma(int a, string b)
        {
            return b;
        }

        public int CalculeazaSuma(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
