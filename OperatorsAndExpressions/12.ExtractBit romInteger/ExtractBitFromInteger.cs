using System;
 //   Write an expression that extracts from given integer n the value of given bit at index p.
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int Value = int.Parse(Console.ReadLine());
        Console.Write("Enter point for bit check: ");
        int Point = int.Parse(Console.ReadLine());
        int bitPoint = 1 << Point;
        int isIt1 = Value & bitPoint, bit = isIt1 >> Point;
        Console.WriteLine("The {0} bit of the integer you entered is: {1}", Point, bit);
    }
}
