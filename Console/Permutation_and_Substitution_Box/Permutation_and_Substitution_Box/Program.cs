using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation_and_Substitution_Box
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
                Console.WriteLine("\n\t\t\t    Substitution And Permutation Box\n");
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.Write("\n\n     *****  Menu  *****\n\n 1). Standard Substitution\n\n 2). Standard Permutation \n\n 3). Expansion Permutation\n\n 4). Compression Permutation\n\n 5). Exit\n\n--> Enter Your Choice : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        S_BOX();
                        break;
                    case 2:
                        P_BOX();
                        break;
                    case 3:EP_BOX();
                        break;
                    case 4:CP_BOX();
                        break;
                    case 5: Environment.Exit(0);
                        break;
                    default:Console.Write("\n\n Wrong Choice");
                        break;
                } 
                Console.WriteLine("\n\n\n\n\n\n");
                Console.ReadKey();
            } while (choice != 5);
        }

        public static void S_BOX()
        {
          int[,] box = new int[,]
          {
              { 58,   50,   42,    34,    26,   18,    10,    2 },
              { 60,   52,   44,    36,    28,   20,    12,    4 },
              { 62,   54,   46,    38,    30,   22,    14,    6 },
              { 64,   56,   48,    40,    32,   24,    16,    8 },
              { 57,   49,   41,    33,    25,   17,    9,     1 },
              { 59,   51,   43,    35,    27,   19,    11,    3 },
              { 61,   53,   45,    37,    29,   21,    13,    5 },
              { 63,   55,   47,    39,    31,   23,    15,    7 },
          };

            //int[,] num = new int[,]
            //{
            //  { 1,    2,    3,     4,     5,    6,     7,    8  },
            //  { 9,    10,   11,    12,    13,   14,    15,   16 },
            //  { 17,   18,   19,    20,    21,   22,    23,   24 },
            //  { 25,   26,   27,    28,    29,   30,    31,   32 },
            //  { 33,   34,   35,    36,    37,   38,    39,   40 },
            //  { 41,   42,   43,    44,    45,   46,    47,   48 },
            //  { 49,   50,   51,    52,    53,   54,    55,   56 },
            //  { 57,   58,   59,    60,    61,   62,    63,   64 },
            //};


        }

        public static void P_BOX()
        {
            // Please give extra array space to hold delimiting characters
            // Enter int array and char array in console by pressing enter after each value
            // string,char[] can be initialized either through console.readline() or assigning null 
            // But int[] need to be initialized
            int[] operand = new int[35];
            int[] result = new int[35];
            int[] ip_result = new int[35];
            int i, temp=0;
            int[] box = new int[]
            {
                19,18,7,5,9,12,13,1,25,32,30,20,8,2,22,27,3,11,15,28,4,26,6,10,29,17,21,14,16,24,23,31

            };

            int[] IP_box = new int[]
            {
                8,14,17,21,4,23,3,13,5,24,18,6,7,28,19,29,26,2,1,12,27,15,31,30,9,22,16,20,25,11,32,10
            };

            for (i = 0; i < 80; i++)
                Console.Write("-");
            Console.Write("\n\n *****  Permutation Box Operation  *****");
            Console.Write("\n\n Enter Any Number : ");
            for (i = 0; i <= 31; i++)
                operand[i] = int.Parse(Console.ReadLine());
            foreach (int c in operand)
            {
                if (c != 0 && c != 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(1000, 800);
                    Console.WriteLine("\n The Number You Entered is not Binary - Please Enter Again");
                    goto there;
                }
            }
            for (i = 0; i <= 31; i++)
            {
                temp = box[i];
                result[temp-1] = operand[i];

            }
            for(i=0;i<=31;i++)
            {
                temp = IP_box[i];
                ip_result[temp - 1] = result[i];
            }
            Console.Write("\n\n The Initial Array is : \n\n ");
            for (i = 0; i < 32; i++)
            {
                Console.Write(operand[i] + " ");
            }
            Console.Write("\n\n The Permutation Table is : \n\n ");
            for(i=0;i<32;i++)
            {
                Console.Write(box[i] + " ");
            }
            Console.Write("\n\n The Permuted Array is : \n\n ");
            for (i = 0; i < 32; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.Write("\n\n The Inverse Permutation Table is : \n\n ");
            for (i = 0; i < 32; i++)
            {
                Console.Write(IP_box[i] + " ");
            }
            Console.Write("\n\n The Inverse Permuted Array is : \n\n ");
            for (i = 0; i < 32; i++)
            {
                Console.Write(ip_result[i] + " ");
            }
            there:;

        }

        public static void EP_BOX()
        {

        }

        public static void CP_BOX()
        {

        }
    }
}
