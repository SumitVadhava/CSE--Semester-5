using System;

class pro5
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Square\n2. Rectangle\n3. Circle");
            Console.Write("Choose between (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter side of square: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area of square = " + (side * side));
                    break;
                case 2:
                    Console.Write("Enter length: ");
                    double length = double.Parse(Console.ReadLine());

                    Console.Write("Enter breadth: ");
                    double breadth = double.Parse(Console.ReadLine());

                    Console.WriteLine("Area of rectangle = " + (length * breadth));
                    break;
                case 3:
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    Console.WriteLine("Area of circle = " + (Math.PI * radius * radius));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            if (choice < 1 || choice > 3)
            {
                Console.WriteLine("Exiting the program.");
                break;
            }
        }
        
    }
}