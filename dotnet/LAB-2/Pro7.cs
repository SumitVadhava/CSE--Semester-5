using System;

class Salary
{
    private double Basic, TA, DA, HRA, Total;

    public Salary(double basic, double ta, double da = 500, double hra = 1000)
    {
        Basic = basic;
        TA = ta;
        DA = da;
        HRA = hra;
    }

    public void CalculateSalary()
    {
        Total = Basic + TA + DA + HRA;
    }

    public void Display()
    {
        Console.WriteLine("\n--- Salary Details ---");
        Console.WriteLine("Basic Salary: " + Basic);
        Console.WriteLine("TA: " + TA);
        Console.WriteLine("DA: " + DA);
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("Total Salary: " + Total);
    }

    static void Main()
    {
        Console.WriteLine("Enter Basic Salary: ");
        double basic = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter TA: ");
        double ta = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter DA (default 500)(Enter -1 if you wnat default value): ");
        double da = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter HRA (default 1000)(Enter -1 if you wnat default value): ");
        double hra = Convert.ToDouble(Console.ReadLine());

        if(da == -1 && hra == -1)
        {
            Salary emp1 = new Salary(basic,ta);

        }
        else if(da == -1)
        {
            Salary emp1 = new Salary(basic, ta, hra:hra);
        }
        else if(hra == -1)
        {
            Salary emp1 = new Salary(basic, ta, da: da);
        }
        else
        {
            Salary emp1 = new Salary(basic, ta, da, hra);
        }
        
        emp1.CalculateSalary();
        emp1.Display();
    }
}