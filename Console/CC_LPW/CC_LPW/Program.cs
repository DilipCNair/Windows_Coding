using System;

namespace CC_LPW
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l;
            int[] pt = new int[25];
            int[] key = new int[25];
            int[] ct = new int[25];
            int[] crs = new int[30];

            Console.Write("\n Enter The Plaintext : ");
            for(i=0;i<10;i++)
                pt[i] = int.Parse(Console.ReadLine());
            Console.Write("\n Enter The Key : ");
            for (i = 0; i < 5; i++)
                key[i] = int.Parse(Console.ReadLine());

            
            for(i=0;i<4;i++)           
                crs[i] = pt[i + 1];
            crs[4] = pt[0];

            for (i = 5; i < 9; i++)
                crs[i] = crs[i - 4];
            crs[9] = crs[5];

            for (i = 10; i < 14; i++)
                crs[i] = crs[i - 4];
            crs[14] = crs[10];

            for (i = 15; i < 19; i++)
                crs[i] = crs[i - 4];
            crs[19] = crs[15];

            for (i = 20; i < 24; i++)
                crs[i] = crs[i - 4];
            crs[24] = crs[20];

            for (i = 25; i < 29; i++)
                crs[i] = crs[i - 4];
            crs[29] = crs[25];

            for(i=0;i<30;i++)
            Console.Write(crs[i]);
            Console.ReadKey();

        }
    }
}
