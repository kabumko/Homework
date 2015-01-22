using System;
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int Value = int.Parse(Console.ReadLine());
        Console.Write("Enter point for bit check: ");
        int Point = int.Parse(Console.ReadLine());
        int bitPoint = 1 << Point;
        int isIt1 = Value & bitPoint, bit = isIt1 >> Point;
        if (bit == 1) 
        {
            Console.WriteLine("The {0} bit of the integer you entered is: 1  -  True", Point);
        }
        else Console.WriteLine("The {0} bit of the integer you entered is: 1  -  False", Point);
    }
}