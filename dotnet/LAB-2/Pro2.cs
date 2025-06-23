using System;
class Staff
{
    public string Name;
    public string Department;
    public string Experience;
    public string Designation;
    public int salary;

    public void getStaffDetails(int i)
    {
        Console.WriteLine($"Enter {i+1} Staff Name: ");
        Name =  Console.ReadLine();
        Console.WriteLine($"Enter {i+1} Staff Department: ");
        Department = Console.ReadLine();
        Console.WriteLine($"Enter {i + 1} Staff Experience: ");
        Experience = Console.ReadLine();
        Console.WriteLine($"Enter {i + 1} Staff Designation: ");
        Designation = Console.ReadLine();
        Console.WriteLine($"Enter {i + 1} Staff Salary: ");
        salary = Convert.ToInt32(Console.ReadLine());
    }

    public void displayCandidateDetails(Staff staff)
    {
        Console.WriteLine("");
        if (staff.Designation == "HOD")
        {
            Console.WriteLine("Staff Name:"+staff.Name);
            Console.WriteLine("Staff Department:"+staff.Department);
            Console.WriteLine("Staff Experience:"+staff.Experience);
            Console.WriteLine("Staff Designation:"+staff.Designation);
            Console.WriteLine("Staff Salary:"+staff.salary);
        }
        Console.WriteLine("");

    }
}

class Pro2
{
    public static void Main(string[] args)
    {
        Staff []staffs = new Staff[5];

        for (int i = 0; i < staffs.Length; i++)
        {
            staffs[i] = new Staff();
            staffs[i].getStaffDetails(i);
        }
        for (int i = 0; i < staffs.Length; i++)
        {
            staffs[i].displayCandidateDetails(staffs[i]);
        }
        Console.WriteLine("Staff details displayed successfully.");
    }
}