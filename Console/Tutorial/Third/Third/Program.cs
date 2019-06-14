

using System;
using DILIP;

namespace third
{
    class Program
    {
        public static void Main(string[] args)
        {
            Arth.Evennumbers();
            Console.ReadKey();
        }
    }
}

namespace DILIP
{
    class Arth
    {
        public static void Evennumbers()
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }

        }
    }
}
