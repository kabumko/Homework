using System;
//Write a program that reads 3 real numbers from the console and prints their sum.
class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter number a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number b:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The ultimate sum of all numbers is -   {0}", (a+b+c));
    }
}

