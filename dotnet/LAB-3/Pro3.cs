using System;

public abstract class Sum
{
    public abstract int SumOfTwo(int a, int b);
    public abstract int SumOfThree(int a, int b, int c);
}

class Calculate : Sum
{
    public override int SumOfTwo(int a,int b)
    {
        return a + b;
    }

    public override int SumOfThree(int a,int b, int c)
    {
        return a + b + c;
    }
}

public class Program
{
   public static void Main(string[] args)
    {
        Calculate calculate = new Calculate();

        Console.WriteLine("Enter Choice (1 - Sum of Two Number, 2 - Sum of Three Number)");
        int choice = int.Parse(Console.ReadLine());

        if(choice == 1)
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            int result = calculate.SumOfTwo(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is: {result}");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int num3 = int.Parse(Console.ReadLine());

            int result = calculate.SumOfThree(num1, num2, num3);
            Console.WriteLine($"The sum of {num1}, {num2}, and {num3} is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }
    }
}