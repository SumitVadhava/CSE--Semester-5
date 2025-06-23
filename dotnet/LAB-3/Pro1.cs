using System;

public class Program
{
    static double division(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide zero");
        }
        else
        {
            return ((double)num1 / num2);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        try{

            double ans = division(num1, num2);
            Console.WriteLine("The result of division is: " + ans);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}