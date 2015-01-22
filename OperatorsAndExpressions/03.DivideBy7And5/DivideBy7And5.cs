using System;
/*
    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
 */
class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool isItDividable = false;
        Console.WriteLine("Is the number dividable by 7 and 5 at once?");
        if ((number % 7 == 0) && (number % 5 == 0)) 
        {
            isItDividable = true;
        }
        if (number == 0) 
        {
            isItDividable = false;
        }
        Console.WriteLine(isItDividable);
    }
}