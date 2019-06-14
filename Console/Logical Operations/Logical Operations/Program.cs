using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operations
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
                Console.WriteLine("\n\t\t\t    Logical Operations\n");
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.Write("\n\n     *****  Menu  *****\n\n 1). NOT Operation\n\n 2). AND Operation \n\n 3). OR Operation\n\n 4). XOR Operation\n\n 5). XNOR Operation\n\n 6). NAND Operation\n\n 7). NOR Operation\n\n 8). Exit\n\n--> Enter Your Choice : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Logic_NOT();
                        break;
                    case 2:
                        Logic_AND();
                        break;
                    case 3:
                        Logic_OR();
                        break;
                    case 4:
                        Logic_XOR();
                        break;
                    case 5:Logic_XNOR();
                        break;
                    case 6:Logic_NAND();
                        break;
                    case 7:Logic_NOR();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(" \n Wrong Choice");
                        break;
                }
                Console.WriteLine("\n\n\n\n\n\n");
                Console.ReadKey();
            } while (choice != 8);
        }

        public static void Logic_NOT()
        {
            int i;
            string operand, result = null;
            char[] arma = new char[25];
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Logic NOT Operation  *****");
            Console.Write("\n\n Enter The Binary Number : ");
            operand = Console.ReadLine();
            foreach (var c in operand)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            arma = operand.ToCharArray();
            for(i=0;i<arma.Length;i++)
            {
                if (arma[i] == '0')
                    result += '1';
                else
                    result += '0';
            }
            there:;
            Console.Write("\n\n The Result is : " + result);
        }
        public static void Logic_AND()
        {
            string operand1, operand2, result = null;
            int i;
            char[] arma = new char[25]; arma = null;
            char[] arma2 = new char[25]; arma2 = null;
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Logic NOT Operation  *****");
            Console.Write("\n\n Enter First Binary Number : ");
            operand1 = Console.ReadLine();
            Console.Write("\n\n Enter Second Binary Number : ");
            operand2 = Console.ReadLine();
            foreach (var c in operand1)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            foreach (var c in operand2)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            arma = operand1.ToCharArray();
            arma2 = operand2.ToCharArray();

            for (i = 0; i < arma.Length; i++)
            {
                if (arma[i] == '0' & arma2[i] == '0')
                    result += '0';
                if (arma[i] == '0' & arma2[i] == '1')
                    result += '0';
                if (arma[i] == '1' & arma2[i] == '0')
                    result += '0';
                if (arma[i] == '1' & arma2[i] == '1')
                    result += '1';

            }
            Console.Write("\n\n The Result is : " + result);

            there:;

        }
        public static void Logic_OR()
        {
            string operand1, operand2, result = null;
            int i;
            char[] arma = new char[25]; arma = null;
            char[] arma2 = new char[25]; arma2 = null;
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Logic OR Operation  *****");
            Console.Write("\n\n Enter First Binary Number : ");
            operand1 = Console.ReadLine();
            Console.Write("\n\n Enter Second Binary Number : ");
            operand2 = Console.ReadLine();
            foreach (var c in operand1)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            foreach (var c in operand2)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            arma = operand1.ToCharArray();
            arma2 = operand2.ToCharArray();

            for (i = 0; i < arma.Length; i++)
            {
                if (arma[i] == '0' & arma2[i] == '0')
                    result += '0';
                if (arma[i] == '0' & arma2[i] == '1')
                    result += '1';
                if (arma[i] == '1' & arma2[i] == '0')
                    result += '1';
                if (arma[i] == '1' & arma2[i] == '1')
                    result += '1';

            }
            Console.Write("\n\n The Result is : " + result);

            there:;

        }
        public static void Logic_XOR()
        {
            string operand1, operand2, result = null;
            int i;
            char[] arma = new char[25]; arma = null;
            char[] arma2 = new char[25]; arma2 = null;
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Logic XOR Operation  *****");
            Console.Write("\n\n Enter First Binary Number : ");
            operand1 = Console.ReadLine();
            Console.Write("\n\n Enter Second Binary Number : ");
            operand2 = Console.ReadLine();
            foreach (var c in operand1)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            foreach (var c in operand2)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            arma = operand1.ToCharArray();
            arma2 = operand2.ToCharArray();

            for (i = 0; i < arma.Length; i++)
            {
                if (arma[i] == '0' & arma2[i] == '0')
                    result += '0';
                if (arma[i] == '0' & arma2[i] == '1')
                    result += '1';
                if (arma[i] == '1' & arma2[i] == '0')
                    result += '1';
                if (arma[i] == '1' & arma2[i] == '1')
                    result += '0';

            }
            Console.Write("\n\n The Result is : " + result);

            there:;

        }
        public static void Logic_XNOR()
        {
            string operand1, operand2, result = null;
            int i;
            char[] arma = new char[25]; arma = null;
            char[] arma2 = new char[25]; arma2 = null;
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Logic XNOR Operation  *****");
            Console.Write("\n\n Enter First Binary Number : ");
            operand1 = Console.ReadLine();
            Console.Write("\n\n Enter Second Binary Number : ");
            operand2 = Console.ReadLine();
            foreach (var c in operand1)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            foreach (var c in operand2)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            arma = operand1.ToCharArray();
            arma2 = operand2.ToCharArray();

            for (i = 0; i < arma.Length; i++)
            {
                if (arma[i] == '0' & arma2[i] == '0')
                    result += '1';
                if (arma[i] == '0' & arma2[i] == '1')
                    result += '0';
                if (arma[i] == '1' & arma2[i] == '0')
                    result += '0';
                if (arma[i] == '1' & arma2[i] == '1')
                    result += '1';

            }
            Console.Write("\n\n The Result is : " + result);

            there:;

        }
        public static void Logic_NAND()
        {
            string operand1, operand2, result = null;
            int i;
            char[] arma = new char[25]; arma = null;
            char[] arma2 = new char[25]; arma2 = null;
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Logic NAND Operation  *****");
            Console.Write("\n\n Enter First Binary Number : ");
            operand1 = Console.ReadLine();
            Console.Write("\n\n Enter Second Binary Number : ");
            operand2 = Console.ReadLine();
            foreach (var c in operand1)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            foreach (var c in operand2)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            arma = operand1.ToCharArray();
            arma2 = operand2.ToCharArray();

            for (i = 0; i < arma.Length; i++)
            {
                if (arma[i] == '0' & arma2[i] == '0')
                    result += '1';
                if (arma[i] == '0' & arma2[i] == '1')
                    result += '1';
                if (arma[i] == '1' & arma2[i] == '0')
                    result += '1';
                if (arma[i] == '1' & arma2[i] == '1')
                    result += '0';

            }
            Console.Write("\n\n The Result is : " + result);

            there:;

        }
        public static void Logic_NOR()
        {
            string operand1, operand2, result = null;
            int i;
            char[] arma = new char[25]; arma = null;
            char[] arma2 = new char[25]; arma2 = null;
            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Logic NOR Operation  *****");
            Console.Write("\n\n Enter First Binary Number : ");
            operand1 = Console.ReadLine();
            Console.Write("\n\n Enter Second Binary Number : ");
            operand2 = Console.ReadLine();
            foreach (var c in operand1)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            foreach (var c in operand2)
            {
                if (c != '0' && c != '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            arma = operand1.ToCharArray();
            arma2 = operand2.ToCharArray();

            for (i = 0; i < arma.Length; i++)
            {
                if (arma[i] == '0' & arma2[i] == '0')
                    result += '1';
                if (arma[i] == '0' & arma2[i] == '1')
                    result += '0';
                if (arma[i] == '1' & arma2[i] == '0')
                    result += '0';
                if (arma[i] == '1' & arma2[i] == '1')
                    result += '0';

            }
            Console.Write("\n\n The Result is : " + result);

            there:;

        }
    }
}
