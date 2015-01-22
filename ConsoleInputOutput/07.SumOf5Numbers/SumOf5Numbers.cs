using System;
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers with 1 interval between them: ");
        string[] penumbre = Console.ReadLine().Split(' ');
        double a = double.Parse(penumbre[0]);
        double b = double.Parse(penumbre[1]);
        double c = double.Parse(penumbre[2]);
        double d = double.Parse(penumbre[3]);
        double e = double.Parse(penumbre[4]);
        Console.WriteLine("The sum of our numbres is:  " + ( a + b + c + d + e ));
    }
}

