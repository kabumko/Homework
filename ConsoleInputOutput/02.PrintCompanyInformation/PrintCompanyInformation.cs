using System;
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Enter company fax nubmer: ");
        int companyFaxNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter company website: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine("The company information is: \nName: {0}\nAdress: {1}", companyName, companyAdress) ;
        Console.WriteLine("Phone Number: " + companyPhoneNumber);
        Console.WriteLine("Fax number: " + companyFaxNumber);
        Console.WriteLine("Company website: " + companyWebsite);
        Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + ", " + managerAge + " years old, phone: " + managerPhoneNumber);
    }
}

