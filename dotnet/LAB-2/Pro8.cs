using System;

class Distance
{
    private double dist1, dist2, dist3;

    public Distance(double d1, double d2)
    {
        dist1 = d1;
        dist2 = d2;
        dist3 = 0;
    }

    public void AddDistances()
    {
        dist3 = dist1 + dist2;
    }

    public void Display()
    {
        Console.WriteLine("\n--- Distance Addition ---");
        Console.WriteLine("Distance 1: " + dist1);
        Console.WriteLine("Distance 2: " + dist2);
        Console.WriteLine("Total Distance: " + dist3);
    }

    static void Main()
    {
        Console.WriteLine("Enter Distance 1: ");
        double d1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Distance 2: ");
        double d2 = Convert.ToDouble(Console.ReadLine());

        Distance d = new Distance(d1,d2);
        d.AddDistances();
        d.Display();
    }
}