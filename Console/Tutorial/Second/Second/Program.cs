using System;
    class Program
    {
        static void Main()
        {
        Console.WriteLine("\nFirst");
        int[] numbers = new int[3];
        numbers[0] = 0;
        numbers[1] = 1;
        numbers[2] = 3;
        foreach (int k in numbers) // Substitute for - for(k=0;k<numbers.length;k++)
            Console.WriteLine(k); //                    console.writeline(numbers[k]);

        Console.WriteLine("\nSecond"); // for displaying even numbers
        for (int i=0;i<=20;i++)
        {
            if (i % 2 == 1)
                continue;
            Console.WriteLine(i);
        }
        Console.ReadKey();
        }
    }
