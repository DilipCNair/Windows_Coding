using System;
namespace Array_Manipulation
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.ReadKey();
            
        }
        public static void INT_ARAY()
        {
            int i;
            int[] num = new int[25];
            Console.Write("Enter The Limit : ");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} Numbers : ", limit);
            for (i = 0; i < limit; i++)
                num[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers you entered are : ");
            for (i = 0; i < limit; i++)
                Console.Write(num[i] + "\t");
        }
        public static void INT_ARAY2()
        {
            int i, j;
            int k = 0;
            char[] a = new char[10];
            char[] b = new char[10];
            char[,] c = new char[10,10];
            string s;
            Console.Write("\n Enter the String : ");
            s = Console.ReadLine();
            a = s.ToCharArray();
            Console.Write("\n Contents in Character array a is : ");
            for (i=0;i<a.Length;i++)
                Console.Write(a[i]);
            //for (i = 0; i < a.Length; i++)
            //{
            //    b[i] = a[i];
            //}
            //Array.Copy(b, a, 10);
            //Console.Write("\n\n Contents in Character array b is : ");
            //for (i = 0; i < b.Length; i++)
            //    Console.Write(b[i]);
            int count = 0;
            for (i = 0; i<5; i++)
                for (j = 0; j<5; j++)
                {
                    c[i, j] = a[count++];
                    if (count >= a.Length)
                        goto there;
                }
            there:
            Console.Write("\n\n The Matrix is : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 5; j++)
                    Console.Write(" " + c[i, j] + "\t");
            }
            Console.Write("\n\n The Value of count is : "+count);
        }
    }
}
