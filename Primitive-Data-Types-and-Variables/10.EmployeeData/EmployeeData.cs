using System;
/*
    A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    First name; Last name; Age (0...100); Gender (m or f); Personal ID number (e.g. 8306112507); Unique employee number (27560000…27569999);
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
 */
class EmployeeData
{
    static void Main()
    {
        string firstName = "Koko", lastName = "Karakachanov";
        byte age = 25;
        bool gender = true;
        long personalIdNumber = 8306112507;
        decimal uniqueEmployeeNumber = 2756000000007569999;
        Console.WriteLine("First Name = {0}\nLast Name = {1}\nAge = {2}\nMale = {3}\nPersonal ID Number = {4}\nUnique Number = {5}", firstName,lastName,age,gender,personalIdNumber,uniqueEmployeeNumber);
    }
}
