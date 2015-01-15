using System;
/*
   Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.     Check
   https://www.daniweb.com/software-development/csharp/threads/69127/how-to-read-integer-value-in-c   input from int from console   Check
*/
class AgeAfter10Years
{
    static void Main(string[] args)
    {
        int Age;
        Console.WriteLine("Write your age:");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Subject Age:");
        Console.WriteLine(Age);
        Console.WriteLine("After 10 years Subject gets to be ");
        Console.WriteLine(Age + 10);
        Console.WriteLine("years old.");
    }
}
