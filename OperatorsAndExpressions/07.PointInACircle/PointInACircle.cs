using System;
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter coordinates of a point x, y: ");
        double x = double.Parse(Console.ReadLine()),y = double.Parse(Console.ReadLine());
        if ((x * x + y * y <= 4)) 
        {
            Console.WriteLine("True, it is in the circle!");
        }
        else Console.WriteLine("False, it isn't in the circle! It is shunned!!!");
    }
}
