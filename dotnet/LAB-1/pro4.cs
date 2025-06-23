using System;

class pro4
{
    static void Main(string [] args)
    {
        Console.WriteLine("Enter the length (In Feet) = ");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width(In Feet) = ");
        int width = int.Parse(Console.ReadLine());

        int area = length * width;

        Console.WriteLine("Area is: " + area + " square feet");
    }
}