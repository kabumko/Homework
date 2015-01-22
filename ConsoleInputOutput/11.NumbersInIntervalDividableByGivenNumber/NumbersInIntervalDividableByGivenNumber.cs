using System;
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter A then B: ");
        ushort a = ushort.Parse(Console.ReadLine()), b = ushort.Parse(Console.ReadLine()), counter=0;
        if (a > b)
        {
            for (int i = b; i <= a; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    counter++;
                }
            }
        }
        else 
        {
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    counter++;
                }
            }
        }
        Console.WriteLine("\nNumber of numbers that can be clearly divided by 5 between {0} and {1} is:  {2}", a, b, counter);
    }
}
