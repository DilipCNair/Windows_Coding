using System;
namespace main
{
    class main
    {
        public static void Main()
        {
            int choice;
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                int i;
                Console.Clear();
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.WriteLine("\n\t\t\t    Ceaser Cipher Cryptography\n");
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.Write("\n\n     *****  Menu  *****\n\n 1). Ceaser Cypher Encryption\n\n 2). Ceaser Cypher Decryption\n\n 3). Exit\n\n--> Enter Your Choice : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        main.Encrypt();
                        break;
                    case 2:
                        main.Decrypt();
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
            char[] arma = null;
            string PT = null, CT = null;
            int i = 0, key, flag = 0, temp;
            Console.Write("\n");
            for (i = 0; i < 80; i++)
                Console.Write("-");
            i = 0;
            flag = 0;
            Console.Write("\n\n *****  Encryption  *****");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n Enter The Plain Text : ");
            PT = Console.ReadLine();
            bool check = PT.Contains(" ");
            if(check == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Special Characters or digits not allowed in Ceaser cypher encryption");
                goto there;
            }
            arma = PT.ToCharArray();
            foreach (char c in arma)
            {
                if (!Char.IsLetter(c)) //(!Char.IsLetterOrDigit(c) && c!='_')
                    flag = 1;
            }
            if (flag == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Special Characters or digits not allowed in Ceaser cypher encryption");
                goto there;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n Enter The Secret Security Key : ");
            key = int.Parse(Console.ReadLine());
            if (key > 26)
                key = key % 26;
            for (i = 0; i < arma.Length; i++)
            {
                if (arma[i] >= 65 & arma[i] <= 90)
                {
                    temp = (int)(arma[i] + key);
                    if (temp > 90)
                        temp = temp - 26;
                    CT += (char)(temp);
                }
                if (arma[i] >= 97 & arma[i] <= 122)
                {
                    temp = (int)(arma[i] + key);
                    if (temp > 122)
                        temp = temp - 26;
                    CT += (char)(temp);
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n The Cipher Text is : " + CT);
            Console.ForegroundColor = ConsoleColor.Gray;
            there:
            ;
        }

        public static void Decrypt()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            char[] arma = null;
            string PT = null, CT = null;
            int i = 0, key, flag = 0, temp;
            Console.Write("\n");
            for (i = 0; i < 80; i++)
                Console.Write("-");
            i = 0; flag = 0;
            Console.WriteLine("\n\n *****  Decryption  *****");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\n Enter The Cypher Text (Without Space ) : ");
            CT = Console.ReadLine();
            bool check = CT.Contains(" ");
            if (check == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Special Characters or digits not allowed in Ceaser cypher encryption");
                goto end;
            }
            arma = CT.ToCharArray();
            foreach (char c in arma)
            {
                if (!Char.IsLetter(c))
                    flag = 1;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            if (flag == 1)
            {
                Console.Write("\n Special Characters or digits not allowed in Ceaser cypher encryption");
                goto end;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n Enter The Secret Security Key ( Max 26 ) : ");
            key = int.Parse(Console.ReadLine());
            if (key > 26)
                key = key % 26;
            foreach(char b in arma)
            {
                if(b>=65 & b<=90)
                {
                    temp = (int)(b - key);
                    if (temp < 65)
                        temp += 26;
                    PT += (char)(temp);
                }
                if(b>=97 & b<=122)
                {
                    temp = (int)(b - key);
                    if (temp < 97)
                        temp += 26;
                    PT+=(char)(temp);
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n The Plain Text is : " + PT);
            end:
            ;

        }
    }
}



