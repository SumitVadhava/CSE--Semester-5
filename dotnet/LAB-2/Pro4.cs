using System;
class Student
{
    public int Enrollment_No;
    public string Student_Name;
    public string Semester;
    public double CPI;
    public double SPI;

    public Student(int enrollmentNo, string studentName, string semester, double cpi, double spi)
    {
        Enrollment_No = enrollmentNo;
        Student_Name = studentName;
        Semester = semester;
        CPI = cpi;
        SPI = spi;
    }

    public void DisplayStudentDetails()
    {
        Console.WriteLine("Enrollment No: " + Enrollment_No);
        Console.WriteLine("Student Name: " + Student_Name);
        Console.WriteLine("Semester: " + Semester);
        Console.WriteLine("CPI: " + CPI);
        Console.WriteLine("SPI: " + SPI);
    }
}

class Pro4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Enrollment No: ");
        int enrollmentNo = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Student Name: ");
        string studentName = Console.ReadLine();
        
        Console.WriteLine("Enter Semester: ");
        string semester = Console.ReadLine();
        
        Console.WriteLine("Enter CPI: ");
        double cpi = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter SPI: ");
        double spi = Convert.ToDouble(Console.ReadLine());

        Student student = new Student(enrollmentNo, studentName, semester, cpi, spi);
        student.DisplayStudentDetails();
    }
}