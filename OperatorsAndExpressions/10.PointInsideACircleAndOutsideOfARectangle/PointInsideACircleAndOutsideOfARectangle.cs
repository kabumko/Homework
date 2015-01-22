using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("Enter coordinates of a point x, y: ");
        double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
        if ((x-1) * (x-1) + (y-1) * (y-1) <= Math.Pow(1.5,2) && ( (x < -1 || x >5 ) || (y<-1 || y>1) ))
        {
            Console.WriteLine("True, it is in the circle and out the rectange, just amazing!");
        }
        else Console.WriteLine("False, it isn't in the circle or is in the rectangle! Just the normal needless point");
    }
}
