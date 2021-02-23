using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int rezultat1 = calculator.CalculeazaSuma(4, 5);

            int rezultat2 = calculator.CalculeazaSuma(1, 2, 3);

            Search search = new Search();

            //search.SearchItem("text");

            search = new VideoSearch();
            search.SearchItem("images");
            Console.ReadKey();
        }
    }
}
