using System;
class Candidate
{
    int Id;
    string Name;
    int Age;
    float weight;
    float height;

    public void getCandidateDetails()
    {
        Console.WriteLine("Enter Candidate Id: ");
        Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Candidate Name: ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter Candidate Age: ");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Candidate Weight: ");
        weight = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Candidate Height: ");
        height = Convert.ToSingle(Console.ReadLine());
    }

    public void displayCandidateDetails()
    {
        Console.WriteLine("");
        Console.WriteLine("Candidate Details:");
        Console.WriteLine("Candidate Id: " + Id);
        Console.WriteLine("Candidate Name: " + Name);
        Console.WriteLine("Candidate Age: " + Age);
        Console.WriteLine("Candidate Weight: " + weight);
        Console.WriteLine("Candidate Height: " + height);
    }
}

class Pro1
{
    public static void Main(string[] args)
    {
        Candidate candidate1 = new Candidate();
        candidate1.getCandidateDetails();
        candidate1.displayCandidateDetails();
    }
}