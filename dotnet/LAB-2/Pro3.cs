using System;
class Bank_Accouunt
{
    int accountNumber;
    string user_name;
    string accountType;
    string email;
    double balance;
    
    public void getAccountDetails()
    {
        Console.WriteLine("Enter Account Number: ");
        accountNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter User Name: ");
        user_name = Console.ReadLine();
        Console.WriteLine("Enter Account Type: ");
        accountType = Console.ReadLine();
        Console.WriteLine("Enter Email: ");
        email = Console.ReadLine();
        Console.WriteLine("Enter Balance: ");
        balance = Convert.ToDouble(Console.ReadLine());
    }
    public void displayAccountDetails()
    {
        Console.WriteLine("");
        Console.WriteLine("Account Details:");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("User Name: " + user_name);
        Console.WriteLine("Account Type: " + accountType);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Balance: " + balance);
    }
}

class Pro3
{
    public static void Main(string[] args)
    {
        Bank_Accouunt bankAccount1 = new Bank_Accouunt();
        bankAccount1.getAccountDetails();
        bankAccount1.displayAccountDetails();
    }
}