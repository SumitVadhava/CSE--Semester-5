using System;

interface Calculate
{
     int Addition(int a, int b);
     int Subtraction(int a, int b);
}

class Result: Calculate
{
    public  int Addition(int a, int b)
    {
        return a + b;
    }

    public  int Subtraction(int a, int b)
    {
        return a - b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Result result = new Result();
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose operation: 1 for Addition, 2 for Subtraction");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            int sum = result.Addition(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }
        else if (choice == 2)
        {
            int difference = result.Subtraction(num1, num2);
            Console.WriteLine($"The difference between {num1} and {num2} is: {difference}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }

    }
} 