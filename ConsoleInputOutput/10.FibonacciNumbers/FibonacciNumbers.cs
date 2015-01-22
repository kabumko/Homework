﻿using System;
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.     
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter number count: ");
        int n = int.Parse(Console.ReadLine()), sum1 = 0, sum2 = 1;
        for (int i = 0; i < n; i++) 
        {
            if (i % 2 == 0)
            {
                Console.Write(sum1 + " ");
                sum1 += sum2;
            }
            else 
            {
                Console.Write(sum2 + " ");
                sum2 += sum1;
            }
        }
    }
}