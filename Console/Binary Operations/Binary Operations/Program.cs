using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Number System Conversions: -
                Console.Write("\n Enter a Decimal Number : ");
                int num = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(num, 2);
                string octal = Convert.ToString(num, 8);
                string hexadecimal = Convert.ToString(num, 16);
                Console.Write("\n\n\n Binary Representation of {0} is : {1}", num, binary);
                Console.Write("\n\n Octal Representation of {0} is : {1}", num, octal);
                Console.Write("\n\n Hexadecimal Representation of {0} is : {1}", num, hexadecimal);
            */

            /*
                Console.Write("\n Enter a Decimal Number : ");
                int num = int.Parse(Console.ReadLine());
                byte a = (byte)(num >>1);
                byte b = (byte)(num <<1);
                string deci = Convert.ToString(a, 2);
                string deci2 = Convert.ToString(b, 2);
                Console.Write(deci + " " + deci2);
            */

            /*
                int i, j;
                Console.Write("\n Enter The Binary Number : ");
                string binary = Console.ReadLine();
                char[] arma = new char[25];
                char[] arma2 = new char[25];
                arma = null;arma2 = null;
                arma = binary.ToCharArray();
                arma2 = binary.ToCharArray();
                Console.Write("\n The String Output is : " + binary);
                Console.Write("\n The Character Array Output is : ");
                for (i = 0; i < arma.Length; i++)
                    Console.Write(arma[i]);
                int num = int.Parse(binary);
                Console.Write("\n The Number is : " + num);

                for(i=0;i<arma2.Length-1;i++)
                {
                    arma[i] = arma[++i];

                }
            */
            Console.ReadKey();
         }
     }
}
