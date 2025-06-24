using System;

namespace LAB_4
{
    internal class Pro1
    {
       public void readIntNumbers()
        {
            Console.WriteLine("Enter first int number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second int number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of two int numbers is: " + sum(a, b));
        }
        public void readFloatNumbers()
        {
            Console.WriteLine("Enter first float number: ");
            float a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second  float number: ");
            float b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of two float numbers is: " + sum(a, b));
        }
        public float sum(int a, int b)
        {
            return a + b;
        }  
        public float sum(float a, float b)
        {
            return a + b;
        }
    }
}
