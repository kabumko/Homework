using System;
/*
    Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
 */
class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number between 0 and 255: ");
        byte number = byte.Parse(Console.ReadLine());
        bool isItPrime = true;
        for (int i = 1; i < number; i++)
        {
            if ((number % i == 0)&&(i != 1)) 
            {
                isItPrime = false;
            }
        }
        if ((number == 1)||(number == 0)) 
        {
            isItPrime = false;
        }
        Console.WriteLine("The number you entered is prime!  " + isItPrime);
    }
}
// s -3 davashe greshka