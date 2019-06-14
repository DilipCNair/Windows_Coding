using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removing_Duplictes
{
    class Program
    {
        static void Main(string[] args)
        {

            string Key;
            char[] arma = new char[25];
            char[] f = new char[25];
            int i, j, k, found = 0, size=0;


            Console.Write("\n Enter The Key : ");
            Key = Console.ReadLine();
            arma = Key.ToCharArray();
            for (i = 0; i < arma.Length; i++)
                f[i] = arma[i];
            i = 0;
            while(f[i]!='\0')
            {
                size++;
                i++;
            }



            again:
            for (i = 0; i < size; i++)
            {
                for (j = size - 1; j >= 0; j--)
                {
                        if (f[i] == f[j] & i!=j)
                        {
                            for (k = j; k < size - 2; k++)
                            {
                                int next = k + 1;
                                f[k] = f[next];
                            }
                            size--;
                            goto again;
                        }                                               //To remove duplicates in the key (My algorithm not working)
                }
            }



            f[size] = '\0';
            char[] g = new char[25];
            i = 0;
            while (f[i] != '\0')
            {
                g[i] = f[i];
                i++;
            }
            


            Console.Write("\n The Size of Modified Array is : " + size);
            Console.Write("\n\n The Modified Key is : ");
            Console.Write(g);
            Console.ReadKey();
        }
    }
}
