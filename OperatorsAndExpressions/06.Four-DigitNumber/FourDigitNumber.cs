using System;
/*
    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).
    The number has always exactly 4 digits and cannot start with 0.
 */
class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Write a four digit number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the digits of the number is: " + (number % 10 + number / 10 % 10 + number / 100 % 10 + number / 1000));
        Console.WriteLine("The number reversed: " + (number % 10) + (number / 10 % 10) + (number / 100 % 10) + (number / 1000));
        Console.WriteLine("The number with last digit made first: " + (number % 10) + (number / 1000) + (number / 100 % 10) + (number / 10 % 10));
        Console.WriteLine("The second and third digit exchanged: " + (number / 1000) + (number / 10 % 10) + (number / 100 % 10) + (number % 10));
    }
}