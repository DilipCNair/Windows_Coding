using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    class Program
    {
        static void Main(string[] args)
        {
            string lower = "abcd";
            lower.ToUpper();
            string upper = "ABCD";
            upper.ToLower();
            Console.Write(lower+"   "+upper);
            Console.ReadKey();
        }
    }
}
