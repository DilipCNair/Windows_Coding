using System;
namespace main
{
    class main
    {
        public static void Main()
        {
            string key=null, xpos=null;
            bool ptlength=false;
            int choice;
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                int i;
                Console.Clear();
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.WriteLine("\n\t\t\t    PlayFair Cipher Cryptography\n");
                for (i = 0; i < 80; i++)
                    Console.Write("-");
                Console.Write("\n\n     *****  Menu  *****\n\n 1). Encryption\n\n 2). Decryption\n\n 3). Exit\n\n--> Enter Your Choice : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        main.Encrypt(out key, out xpos, out ptlength);
                        break;
                    case 2:
                        main.Decrypt(key,xpos,ptlength);
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
        }                                                                                //Entry point of program







        public static void Encrypt(out string key,out string xpos,out bool ptlength)                                //Playfair Encryption Algorithm
        {


            char[] arma = new char[10];
            char[] arma2 = new char[10];                            //Variables Initialization
            char[,] a = new char[10,10];                            //arma array : array manipulation array
            int temp = 95;
            int i, j,k=0, flag = 0;
            string PT = null, CT = null;
            key = null;
            xpos = null;
            ptlength = false;
            


            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)                            //Initializing matrix with _
                    a[i, j] = (char)temp;
            }

       
           


            Console.Write("\n\n");
            for (i = 0; i < 80; i++)                                //Graphics
                Console.Write("-");



            Console.WriteLine("\n Encryption");
            Console.ForegroundColor = ConsoleColor.Yellow;          //Reading plain text
            Console.Write("\n Enter The Plain Text : ");
            PT = Console.ReadLine();

          


            bool check = PT.Contains(" ");
            if (check == true)
            {                                                          //Checking for Spaces
                Console.ForegroundColor = ConsoleColor.Red;  
                Console.Beep(1000, 800);
                Console.WriteLine("\n Spaces Can't Be Encrypted In PlayFair Cryptography");
                goto there;
            }

            int flag2 = 0;
            arma = PT.ToCharArray();                                   //Converting to upper case

            for (i = 0; i < arma.Length; i++)
            {
                if (char.IsLower(arma[i]))
                {
                    arma[i] -= (char)32;
                }
                   
            }


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
                Console.WriteLine("\n Numbers Can't Be Encrypted Using PlayFair Cryptography");         
                goto there;
            }
            if (flag2 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;            //Checking for special characters
                Console.Beep(1000,800);
                Console.WriteLine("\n Special Characters Can't Be Encrypted Using PlayFair Cryptography");
                goto there;
            }



            Console.Write("\n Enter The Key : ");                   //Reading key
            key = Console.ReadLine();



            string table = "";            
            string result = "";                                     // Store the result in this string.            
            foreach (char value in key)                             // Loop over each character.
            {                                                       // See if character is in the table.                                                                       
                if (table.IndexOf(value) == -1)
                {                                                   //Algorithm from Internet to remove duplicates in the key            
                    table += value;                                 
                    result += value;                            // Append to the table and the result.
                }
            }
            key=string.Copy(result);



            arma2 = key.ToCharArray();                              //arma has plaint text and arma2 has the key
            for (i = 0; i < arma2.Length; i++)                       //converting key to upper case if required
            {
                if (char.IsLower(arma2[i]))
                    arma2[i] -= (char)32;
            }




            int count = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    a[i, j] = arma2[count++];                       //Key Entry in matrix by converting 1D Array to 2D Array
                    if (count >= arma2.Length)
                        goto enough;
                }

            }
            enough:





            count = 0;
            int temp2 = 65;
            for (i=0; i < 5; i++)
            {
                for (j=0; j < 5; j++)                               //Matrix table entry remaining
                {
                    flag = 0;
                    if(temp2==74)                                   //To skip j
                    {
                        temp2++;
                        i -= 1;
                        j -= 1;
                        continue;
                    }
                    if (a[i, j] == '_')
                    {
                        for (k = 0; k < arma2.Length; k++)          // To check duplicates in matrix while entering values
                        {
                            if ((char)temp2 == arma2[k])
                            {
                                flag = 1;
                            }                            
                        }
                        if (flag==0)
                                a[i, j] = (char)(temp2++);          // if no then print
                        if(flag==1)                                 // if yes then increment the value and check again
                        {
                            i = i - 1;
                            j = j - 1;
                            temp2 += 1;
                        }
                    }
                }
            }






            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n The Matrix is : ");
            for (i = 0; i < 5; i++)
            {                                                       //matrix displaying
                Console.Write("\n");
                for (j = 0; j < 5; j++)
                {
                    Console.Write(" " + a[i, j] + "\t");
                }
            }


            int size=0;
            char[] f = new char[25];
            for (i = 0; i < arma.Length; i++)
                f[i] = arma[i];                 //Since arma is converted array of PT we can't add 
            i = 0;                              //elements to it from the arma.length.
            while (f[i] != '\0')                //Here since f array is again converted array of arma array,
            {                                   //f.length is always total array length, don't know why.
                size++;
                i++;
            }
            for (i = 0; i < size; i++)          //To replace i with j in the plain text
            {
                if (f[i] == 'J')
                    f[i] = 'I';
            }
            again:
            for (i = 0; i < size - 1; i++)
            {
                int next = i + 1;
                if (f[i] == f[next] & (next) % 2 != 0)  //To insert x if required
                {
                    for (j = size; j > i; j--)
                    {
                        f[j] = f[j - 1];
                    }
                    f[i + 1] = 'X';
                    size++;
                    goto again;
                }               
            }
            if (size % 2 != 0)                      //To insert x in the end if length is odd
            {
                ptlength = false;
                f[size] = 'X';
                size++;
            }
            Console.Write("\n\n The New Plaint Text For Comparison is: ");
            for (i = 0; i < size; i++)
            {
                Console.Write(f[i]);                                        // Displaying the new plain text with spaces
                if (i % 2 != 0)
                    Console.Write(" ");
            }

            int r1, c1, r2, c2, l;
            count = 0;
           repeat:
            for(i=0;i< 5;i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (a[i, j] == f[count])
                    {
                        r1 = i;
                        c1 = j;
                        count++;
                        for (k = 0; k < 5; k++)
                        {
                            for (l = 0; l < 5; l++)
                            {
                                if (a[k, l] == f[count])
                                {
                                    r2 = k;
                                    c2 = l;
                                    count++;
                                    if (r1 == r2 | c1 == c2)
                                    {
                                        if(r1==r2)
                                        {
                                            if (c1 == 4)
                                            {
                                                CT += a[r1, 0];
                                                CT += a[r2, c2 + 1];
                                            }
                                            if (c2 == 4)
                                            {
                                                CT += a[r1, c1+1];
                                                CT += a[r2, 0];
                                            }       
                                            if (c1 != 4 & c2 != 4)
                                            {                                   //Algorithm to compare modified plain text and the matrix to make cypher text
                                                CT += a[r1, c1 + 1];
                                                CT += a[r2, c2 + 1];
                                            }
                                        }
                                        if(c1==c2)
                                        {
                                            if (r1 == 4)
                                            {
                                                CT += a[0, c1];
                                                CT += a[r2 + 1, c2];
                                            }
                                            if (r2 == 4)
                                            {
                                                CT += a[r1+1, c1];
                                                CT += a[0, c2];
                                            }
                                            if (r1 != 4 & r2 != 4)
                                            {
                                                CT += a[r1 + 1, c1];
                                                CT += a[r2 + 1, c2];
                                            }
                                        }
                                    }
                                    else
                                    {
                                        CT += a[r1, c2];
                                        CT += a[r2, c1];
                                    }
                                    goto end;                                      
                                }
                            }
                        }
                    }                   
                }
            }
            end:
            if (count < size - 1)
                goto repeat;
            char[] ct = new char[25];
            ct = CT.ToCharArray();

            Console.ForegroundColor = ConsoleColor.Blue;            //Displaying Cypher text
            Console.Write("\n\n The Cypher Text is: ");
            for (i = 0; i < ct.Length; i++)
            {
                Console.Write(ct[i]);
                if (i % 2 != 0)
                    Console.Write(" ");
            }
            there:
            ;
        }







        public static void Decrypt(string key,string xpos,bool ptlength)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            char[] arma = null;
            string PT = null, CT = null;
            char[] arma2 = new char[25];
            int i = 0, flag = 0, temp = 95, j;
            char[,] a = new char[25, 25];



            Console.Write("\n");
            for (i = 0; i < 80; i++)
                Console.Write("-");



            i = 0; flag = 0;
            Console.WriteLine("\n\n *****  Decryption  *****");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\n Enter The Cypher Text (Without Space ) : ");
            CT = Console.ReadLine();



            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)                            //Initializing matrix with _
                    a[i, j] = (char)temp;
            }



            bool check = CT.Contains(" ");
            if (check == true)
            {                                                          //Checking for Spaces
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep(1000, 800);
                Console.WriteLine("\n Spaces Can't Be Encrypted In PlayFair Cryptography");
                goto end;
            }

            int flag2 = 0;
            arma = CT.ToCharArray();                                   //Converting to upper case

            for (i = 0; i < arma.Length; i++)
            {
                if (char.IsLower(arma[i]))
                    arma[i] -= (char)32;
            }


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
                Console.WriteLine("\n Numbers Can't Be Encrypted Using PlayFair Cryptography");
                goto end;
            }
            if (flag2 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;            //Checking for special characters
                Console.Beep(1000, 800);
                Console.WriteLine("\n Special Characters Can't Be Encrypted Using PlayFair Cryptography");
                goto end;
            }


            arma2 = key.ToCharArray();
            int count = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    a[i, j] = arma2[count++];                       //Key Entry in matrix by converting 1D Array to 2D Array
                    if (count >= arma2.Length)
                        goto enough;
                }

            }
            enough:



            count = 0;
            int temp2 = 65, k;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)                               //Matrix table entry remaining
                {
                    flag = 0;
                    if (temp2 == 74)                                   //To skip j
                    {
                        temp2++;
                        i -= 1;
                        j -= 1;
                        continue;
                    }
                    if (a[i, j] == '_')
                    {
                        for (k = 0; k < arma2.Length; k++)          // To check duplicates in matrix while entering values
                        {
                            if ((char)temp2 == arma2[k])
                            {
                                flag = 1;
                            }
                        }
                        if (flag == 0)
                            a[i, j] = (char)(temp2++);          // if no then print
                        if (flag == 1)                                 // if yes then increment the value and check again
                        {
                            i = i - 1;
                            j = j - 1;
                            temp2 += 1;
                        }
                    }
                }
            }
            repeat:
            int size = 0;
            char[] f = new char[25];
            //f = null;
            
            for (i = 0; i < arma.Length; i++)
                f[i] = arma[i];                 //Since arma is converted array of PT we can't add 
            i = 0;                              //elements to it from the arma.length.
            while (f[i] != '\0')                //Here since f array is again converted array of arma array,
            {                                   //f.length is always total array length, don't know why.
                size++;
                i++;
            }



           
            int r1, c1, r2, c2, l;
            count = 0;
            for (i = 0; i < 10; i++)
                count++;

            
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (a[i, j] == f[count])
                    {
                        r1 = i;
                        c1 = j;
                        count++;
                        for (k = 0; k < 5; k++)
                        {
                            for (l = 0; l < 5; l++)
                            {
                                if (a[k, l] == f[count])
                                {
                                    r2 = k;
                                    c2 = l;
                                    count++;
                                    if (r1 == r2 | c1 == c2)
                                    {
                                        if (r1 == r2)
                                        {
                                            if (c1 == 4)
                                            {
                                                PT += a[r1, 0];
                                                PT += a[r2, c2 + 1];
                                            }
                                            if (c2 == 4)
                                            {
                                                PT += a[r1, c1 + 1];
                                                PT += a[r2, 0];
                                            }
                                            if (c1 != 4 & c2 != 4)
                                            {                                   //Algorithm to compare modified plain text and the matrix to make cypher text
                                                PT += a[r1, c1 + 1];
                                                PT += a[r2, c2 + 1];
                                            }
                                        }
                                        if (c1 == c2)
                                        {
                                            if (r1 == 4)
                                            {
                                                PT += a[0, c1];
                                                PT += a[r2 + 1, c2];
                                            }
                                            if (r2 == 4)
                                            {
                                                PT += a[r1 + 1, c1];
                                                PT += a[0, c2];
                                            }
                                            if (r1 != 4 & r2 != 4)
                                            {
                                                PT += a[r1 + 1, c1];
                                                PT += a[r2 + 1, c2];
                                            }
                                        }
                                    }
                                    else
                                    {
                                        PT += a[r1, c2];
                                        PT += a[r2, c1];
                                    }
                                    goto THERE;
                                }
                            }
                        }
                    }
                }
            }
            end:
            //if (count < size - 1)
            //    goto repeat;
            char[] pt = new char[25];
            pt = PT.ToCharArray();

            Console.ForegroundColor = ConsoleColor.Yellow;
            PT = string.Copy(CT);
            Console.Write("\n The Plain text is : " + PT);
            THERE:
            ;
        }                                        //Playfair Decryption Algorithm
    }
}