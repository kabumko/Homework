using System;
/*
    Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0.
*/
class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Enter the integer: ");
        int Integeeer = int.Parse(Console.ReadLine()), bitPoint = 1 << 3;
        int isIt1 = Integeeer & bitPoint, bit = isIt1 >> 3;
        Console.WriteLine(bit);
    }
}