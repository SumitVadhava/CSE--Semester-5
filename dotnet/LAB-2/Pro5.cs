using System;
class Rectangle
{
    public double Length;
    public double Width;
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    public double Area()
    {
        return Length * Width;
    }
    
}

class Pro5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Length of Rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter Width of Rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());
        
        Rectangle rectangle = new Rectangle(length, width);
       
        double area = rectangle.Area();
        
        Console.WriteLine("Area of Rectangle: " + area);
    }
}