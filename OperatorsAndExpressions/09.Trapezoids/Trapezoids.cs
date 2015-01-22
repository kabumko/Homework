using System;
/*
    Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter a:  ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter b:  ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter height:  ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Area of trapezoid with that characteristics is: " + ((sideA+sideB)*height)/2);
    }
}
