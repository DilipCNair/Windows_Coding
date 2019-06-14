using System;

class FindArea
{
    public static void Main()
    {
        int choice;
        do
        {
            Console.Clear();
            double? ac, aq, ar;   // ? Is To make  Variables Nullable
            ac = null;
            aq = null;
            ar = null;
            Console.WriteLine("\n\t\t\t\t Welcome to c#\n\n\n\n Menu\n\n 1.Area of a circle\n\n 2.Area of a square\n\n 3.Area of a rectangle\n\n 4.Exit\n\n Enter your choice:");
            choice = int.Parse(Console.ReadLine()); // Default input is char, thus converting into int
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the radius : ");
                    int radius = int.Parse(Console.ReadLine());
                    ac = 3.14 * radius * radius;
                    Console.WriteLine("The area of the circle is " + ac);
                    break;

                case 2:
                    Console.WriteLine("Enter the side : ");
                    int side = Convert.ToInt32(Console.ReadLine());// Another method to convert char to int
                    aq = side * side;
                    Console.WriteLine("The are of the square is : " + aq);
                    break;

                case 3:
                    Console.WriteLine("Enter the Length : ");
                    double length, breadth;
                    length = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Breadth :");
                    breadth = Convert.ToDouble(Console.ReadLine());
                    ar = 0.5 * length * breadth;
                    Console.WriteLine("The area of the rectangle is " + ar);
                    break;

                case 4:
                    Environment.Exit(0); // to exit
                    break;

                default:
                    Console.WriteLine("You have entered a wrong choice");
                    break;
            }
            Console.ReadKey(); // to pause the console
        } while (choice != 4);

    }

}