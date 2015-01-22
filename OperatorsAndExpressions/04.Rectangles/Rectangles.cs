using System;
// Write an expression that calculates rectangle’s perimeter and area by given width and height.
class Rectangles
{
    static void Main()
    {
        Console.Write("Enter an width of a rectangle: ");
        double wLength = double.Parse(Console.ReadLine());
        Console.Write("Enter an height of a rectangle: ");
        double hLength = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the rectangle is : " + ((wLength*2)+(hLength*2)));
        Console.WriteLine("The area of the rectangle is : " + (wLength*hLength));
    }
}

