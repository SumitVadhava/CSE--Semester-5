using System;

class pro1
{
       static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your address:");
        string address = Console.ReadLine();

        Console.WriteLine("Enter your phone number:");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Enter your city:");
        string city = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Name :" + name + "\nAddress : " + address + "\nContact :" + phoneNumber + "\nCity :" + city);
    }
}


