using System;
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a:  ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b:  ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c:  ");
        double c = double.Parse(Console.ReadLine());
        double d = b*b-4*a*c;
        if (d > 0)
        {
            Console.WriteLine("x1 = " + (-b - Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("x2 = " + (-b + Math.Sqrt(d)) / (2 * a));
        }
        else
        {
            if(d==0)
            {
                Console.WriteLine("x1 = x2 = " + (-b/(2*a)));
            }
            else Console.WriteLine("no real roots");
        }   
            
    }
}
