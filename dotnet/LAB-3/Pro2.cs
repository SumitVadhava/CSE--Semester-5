using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Enter {i + 1} Number:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        try
        {
            Console.WriteLine("Enter the index of the element you want to access:");
            int idx = int.Parse(Console.ReadLine());
            Console.WriteLine($"The element at {idx}:" + arr[idx]);

        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine("An unexpected error occurred: " + e.Message);
        }
    }
}