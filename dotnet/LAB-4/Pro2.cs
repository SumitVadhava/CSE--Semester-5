﻿using System;
//Write a program using method overloading by changing number of arguments to calculate area of square and rectangle
namespace LAB_4
{
    internal class Pro2
    {
        public void readSquareArea()
        {
            Console.WriteLine("Enter side length of square: ");
            float side = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Area of square is: " + area(side));
        }
        public void readRectangleArea()
        {
            Console.WriteLine("Enter length of rectangle: ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle: ");
            float width = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Area of rectangle is: " + area(length, width));
        }
        public float area(float side)
        {
            return side * side;
        }
        public float area(float length, float width)
        {
            return length * width;

        }
    }
}
