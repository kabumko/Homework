using System;
/*
    The gravitational field of the Moon is approximately 17% of that on the Earth.    
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */
class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter kilograms of a thing on Earth: ");
        double kgEarth = double.Parse(Console.ReadLine()), kgMoon;
        kgMoon = (kgEarth / 100) * 17;
        Console.WriteLine("That thing will weight {0} kilograms on the Moon", kgMoon);
    }
}

