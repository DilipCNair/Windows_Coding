
using System;
using DILIP;

namespace Main
{
    class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n Enter the limit for both odd and even numbers : ");
            int limit = int.Parse(Console.ReadLine());
            Arth.Evennumbers(limit);
            Arth p = new Arth();
            Console.WriteLine("\n\n");
            p.oddnumbers(limit);
            Console.ReadKey();
        }
    }
}


namespace DILIP
{
    class Arth
    {
        public static void Evennumbers(int limit)
        {
            int start = 0;
            Console.WriteLine("Even Number are :\n");
            while (start <= limit)
            {
                Console.WriteLine(start);
                start = start + 2;
            }

        }

        public void oddnumbers(int limit)
        {
            int i = 0;
            Console.WriteLine("Odd Number are :\n");
            for (i = 0; i <= limit; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
