using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c5
{
    public class Search
    {
        public string Message { get; set; }
        public virtual void SearchItem(string input)
        {
            Console.WriteLine($"Search items {input}");
        }
    }

    public class ImageSearch : Search
    {
        
    }

    public class VideoSearch : Search
    {
        public override void SearchItem(string input)
        {
            Console.WriteLine(string.Format("Search videos {0}", input));
        }
    }
}
