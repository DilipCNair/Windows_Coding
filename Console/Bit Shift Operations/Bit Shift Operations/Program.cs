using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Shift
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice;
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                int i;
                Console.Clear();
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.WriteLine("\n\t\t\t    Bit Shift Operations\n");
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.Write("\n\n     *****  Menu  *****\n\n 1). Linear Right Shift\n\n 2). Linear Left Shift \n\n 3). Circular Right Shift\n\n 4). Circular Left Shift\n\n 5). Exit\n\n--> Enter Your Choice : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        LRS();
                        break;
                    case 2:
                        LLS();
                        break;
                    case 3:
                        CRS();
                        break;
                    case 4:
                        CLS();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(" \n Wrong Choice");
                        break;
                }
                Console.WriteLine("\n\n\n\n\n\n");
                Console.ReadKey();
            } while (choice != 5);
        }

        public static void LRS()
        {
            string binary, LRSbin; LRSbin = null;
            int i, j, count = 0;
            char[] arma = new char[25]; arma = null;
            Console.Write("\n");
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Linear Right Shift  *****");
            Console.Write("\n\n Enter The Binary Number : ");
            binary = Console.ReadLine();
            arma = binary.ToCharArray();
            foreach (var c in binary)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            Console.Write("\n Enter how many bits to be Shifted Linearly : ");
            int Rshift = int.Parse(Console.ReadLine());
            do
            {
                int previous;
                for (i = arma.Length - 1; i > 0; i--)
                {
                    previous = i - 1;
                    arma[i] = arma[previous];
                }
                count++;
                arma[0] = '0';
                if (count <= Rshift)
                {
                    Console.Write("\n After Iteration " + count + " : ");
                    for (j = 0; j < arma.Length; j++)
                        Console.Write(arma[j]);
                }
            } while (count < Rshift);

            for (j = 0; j < arma.Length; j++)
                LRSbin += arma[j];

            Console.Write("\n\n The Binary Number After Linear Right Shift is  : " + LRSbin);
            there:;

        }

        public static void LLS()
        {
            string binary, LLSbin; LLSbin = null;
            int i, j, count = 0;
            char[] arma = new char[25]; arma = null;
            Console.Write("\n");
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Linear Left Shift  *****");
            Console.Write("\n\n Enter The Binary Number : ");
            binary = Console.ReadLine();
            arma = binary.ToCharArray();
            foreach (var c in binary)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            Console.Write("\n Enter how many bits to be Shifted Linearly : ");
            int Lshift = int.Parse(Console.ReadLine());
            do
            {
                int next;
                for (i = 0; i < arma.Length - 1; i++)
                {
                    next = i + 1;
                    arma[i] = arma[next];
                }
                count++;
                arma[arma.Length - 1] = '0';
                if (count <= Lshift)
                {
                    Console.Write("\n After Iteration " + count + " : ");
                    for (j = 0; j < arma.Length; j++)
                        Console.Write(arma[j]);
                }
            } while (count < Lshift);

            for (j = 0; j < arma.Length; j++)
                LLSbin += arma[j];

            Console.Write("\n\n The Binary Number After Linear Left Shift is  : " + LLSbin);
            there:;

        }

        public static void CRS()
        {
            string binary, CRSbin; CRSbin = null;
            int i, j, count = 0;
            char[] arma = new char[25]; arma = null;
            Console.Write("\n");
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Right Circular Shift  *****");
            Console.Write("\n\n Enter The Binary Number : ");
            binary = Console.ReadLine();
            arma = binary.ToCharArray();
            foreach (var c in binary)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            Console.Write("\n Enter how many bits to be shifted circularly : ");
            int Rshift = int.Parse(Console.ReadLine());
            do
            {
                char af = arma[0];
                int next;
                for (i = 0; i < arma.Length - 1; i++)
                {
                    next = i + 1;
                    arma[i] = arma[next];
                }
                count++;
                arma[arma.Length - 1] = af;
                if (count <= Rshift)
                {
                    Console.Write("\n After Iteration " + count + " : ");
                    for (j = 0; j < arma.Length; j++)
                        Console.Write(arma[j]);
                }
            } while (count < Rshift);

            for (j = 0; j < arma.Length; j++)
                CRSbin += arma[j];

            Console.Write("\n\n The Binary Number After Circular Right Shift is  : " + CRSbin);
            there:;
        }

        public static void CLS()
        {
            string binary, CLSbin; CLSbin = null;
            int i, j, count = 0;
            char[] arma = new char[25]; arma = null;
            Console.Write("\n");
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Left Circular Shift  *****");
            Console.Write("\n\n Enter The Binary Number : ");
            binary = Console.ReadLine();
            arma = binary.ToCharArray();
            foreach (var c in binary)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            Console.Write("\n Enter how many bits to be shifted circularly : ");
            int Lshift = int.Parse(Console.ReadLine());
            do
            {
                char af = arma[arma.Length - 1];
                int previous;
                for (i = arma.Length - 1; i > 0; i--)
                {
                    previous = i - 1;
                    arma[i] = arma[previous];
                }
                count++;
                arma[0] = af;
                if (count <= Lshift)
                {
                    Console.Write("\n After Iteration " + count + " : ");
                    for (j = 0; j < arma.Length; j++)
                        Console.Write(arma[j]);
                }
            } while (count < Lshift);

            for (j = 0; j < arma.Length; j++)
                CLSbin += arma[j];

            Console.Write("\n\n The Binary Number After Circular Left Shift is  : " + CLSbin);
            there:;

        }
    }
}
