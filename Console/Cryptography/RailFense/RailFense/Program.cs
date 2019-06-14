using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailFense
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice, i;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.WriteLine("\n\t\t\t     RailFense Cryptography\n");
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.Write("\n\n     *****  Menu  *****\n\n 1). Encryption\n\n 2). Decryption\n\n 3). Exit\n\n--> Enter Your Choice : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:Encrypt();
                        break;
                    case 2:Decrypt();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(" \n Wrong Choice");
                        break;
                }
                Console.WriteLine("\n\n\n\n\n\n");
                Console.ReadKey();
            } while (choice != 3);
        }

        public static void Encrypt()
        {
            string PT, CT;
            char[,] pt = new char[3, 10];
            char[,] ct = new char[3, 10];
            char[] arma = new char[30];
            CT = null;
            int i, j, flag=0, flag2=0;
            Console.Write("\n\n");
            for (i = 0; i < 80; i++)                                //Graphics
                Console.Write("-");



            Console.WriteLine("\n Encryption");
            Console.ForegroundColor = ConsoleColor.Yellow;          //Reading plain text
            Console.Write("\n Enter The Plain Text : ");
            PT = Console.ReadLine();

            arma = PT.ToCharArray();                                //Converting to upper case



            foreach (char c in arma)
            {
                if (char.IsDigit(c))                                   //(!Char.IsLetterOrDigit(c) && c!='_') if required
                    flag = 1;
                if (!Char.IsLetterOrDigit(c))
                    flag2 = 1;
            }
            if (flag == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;            //Checking for numbers
                Console.Beep(1000, 800);
                Console.WriteLine("\n Numbers Can't Be Encrypted Using Railfense Cryptography");
                goto there;
            }
            if (flag2 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;            //Checking for special characters
                Console.Beep(1000, 800);
                Console.WriteLine("\n Special Characters Can't Be Encrypted Using Railfense Cryptography");
                goto there;
            }




            for (i = 0; i < arma.Length; i++)
            {
                if (char.IsLower(arma[i]))
                    arma[i] -= (char)32;
            }


            int temp = 95;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 10; j++)
                {                                                                    //Initializing matrix with _
                    pt[i, j] = (char)temp;
                    ct[i, j] = (char)temp;
                }
            }


            int count = 0;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 3; j++)                                     //Entering plain text to 2d array column wise order
                {
                    ct[j,i] = arma[count++];                       
                    if (count >= arma.Length)
                        goto enough;
                }

            }
            enough:
            ;
            for(i=0;i<3;i++)
            {
                for(j=0;j<10;j++)                                           //Writing into cypher text variable row wise
                {
                    if((char)ct[i,j]!='_')
                    CT += ct[i,j];
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n The RailFense Order of Plain Text is :-");
            for(i=0;i<3;i++)
            {
                Console.Write("\n ");
                for(j=0;j<10;j++)
                {
                    Console.Write(ct[i, j] + " ");
                }
            }


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\n The Cypher Text is : " + CT);
            there:;

        }

        public static void Decrypt()
        {
            string PT, CT;
            char[,] pt = new char[3, 10];
            char[,] ct = new char[3, 10];
            char[] arma = new char[30];
            CT = null;
            PT = null;
            int i, j, flag = 0, flag2 = 0;
            Console.Write("\n\n");
            for (i = 0; i < 80; i++)                                //Graphics
                Console.Write("-");



            Console.WriteLine("\n Decryption");
            Console.ForegroundColor = ConsoleColor.Blue;          //Reading plain text
            Console.Write("\n Enter The Cypher Text : ");
            CT = Console.ReadLine();

            arma = CT.ToCharArray();                                //Converting to upper case



            foreach (char c in arma)
            {
                if (char.IsDigit(c))                                   //(!Char.IsLetterOrDigit(c) && c!='_') if required
                    flag = 1;
                if (!Char.IsLetterOrDigit(c))
                    flag2 = 1;
            }
            if (flag == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;            //Checking for numbers
                Console.Beep(1000, 800);
                Console.WriteLine("\n Numbers Can't Be Encrypted Using Railfense Cryptography");
                goto end;
            }
            if (flag2 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;            //Checking for special characters
                Console.Beep(1000, 800);
                Console.WriteLine("\n Special Characters Can't Be Encrypted Using Railfense Cryptography");
                goto end;
            }




            for (i = 0; i < arma.Length; i++)
            {
                if (char.IsLower(arma[i]))
                    arma[i] -= (char)32;
            }

            int temp = 95;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 10; j++)
                {                                                                    //Initializing matrix with _
                    pt[i, j] = (char)temp;
                    ct[i, j] = (char)temp;
                }
            }


          
                int count = 0;
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 3; j++)                                     //Entering plain text to 2d array column wise order
                    {
                        ct[j, i] = arma[count++];
                        if (count >= arma.Length)
                            goto enough;
                    }

                }
                enough:
                ;
                PT = null;
            count = 0;
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 10; j++)                                           //Writing into cypher text variable row wise
                    {
                    if ((char)ct[i, j] != '_')
                    {
                        pt[i, j] = arma[count++];
                    }
                        
                    }
                }

          


            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 3; j++)                                           //Writing into cypher text variable row wise
                {
                    if ((char)pt[j,i] != '_')
                        PT += pt[j, i];
                }
            }



            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n The RailFense Order of Cypher Text is :-");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n ");
                for (j = 0; j < 10; j++)
                {
                    Console.Write(pt[i, j] + " ");
                }
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n \nThe Plain Text is : " + PT);
            end:;
        }
 
     }
}
