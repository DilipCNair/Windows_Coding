using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DILIP
{
    class ArthFn
    {
        public static void Evennumbers() // instance method : public is access modifier
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

