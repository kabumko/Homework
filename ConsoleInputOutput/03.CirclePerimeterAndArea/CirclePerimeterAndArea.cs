using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter Radius: ");
        double r = double.Parse(Console.ReadLine()), Pi = 3.14159265;
        Console.WriteLine("Perimeter of circle is:  " + Math.Round(Pi*(r+r), 2));
        Console.WriteLine("Area of the circle is: " + Math.Round((Pi*r*r), 2));
    }
}

 