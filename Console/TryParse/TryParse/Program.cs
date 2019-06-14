using System;
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            int num;
            Console.WriteLine("Enter a number : ");
            input = Console.ReadLine();
            int.TryParse(input, out num);
            Console.WriteLine("Number yuu entered is : "+ num);
            Console.ReadKey();
        }
  }
