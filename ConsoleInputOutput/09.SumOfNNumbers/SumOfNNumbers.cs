using System;
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
//Note: You may need to use a for-loop.
class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter a number, for number count: ");
        double n = double.Parse(Console.ReadLine()), sum = 0, n2;
        for (int i = 0; i < n; i++) 
        {
            Console.Write("Enter a number: ");
            n2 = double.Parse(Console.ReadLine());
            sum += n2;
        }
        Console.WriteLine("The sum of the entered numbers is: " + sum);
    }
}

