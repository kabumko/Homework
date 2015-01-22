using System;
//  Write an expression that checks if given integer is odd or even.
class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        //Znachi, console read line vuvejda string ili char, i biva preobrazuvano s Parse v int i prisvoeno. Taka moje da se vuvejda int ot konzolata!!!
        int number = int.Parse(Console.ReadLine());
        bool isItEven = true;
        Console.WriteLine("Is the number Odd?");
        if (number % 2 == 0) 
        {
            isItEven = false;
        }
        Console.WriteLine(isItEven);
    }
}
