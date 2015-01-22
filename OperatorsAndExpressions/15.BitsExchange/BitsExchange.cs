// For some reason there is an logic error in this program, i can't find it, neither with the logic or with the debugger. If you can, tell me my error in the comment.


using System;
//      Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter a big int");
        uint number = uint.Parse(Console.ReadLine());
        uint bitcomp1, bitcomp2;

        uint comparater = 1 << 3;
        bitcomp1 = number & comparater;
        comparater = 1 << 24;
        bitcomp2 = number & comparater;  // Razmqna 3 ti s 24 bit
        
        if ((bitcomp1 & number) != (bitcomp2 & number))// ako 2 ta bita sa ednakvi ochevidno ne pravim nishto, => ako ne sa deistvame
        {
            if ((bitcomp1 & number) == 1) //ako 3tiq bit e 1 to drugiq e 0
            {
                comparater = 1 << 3;
                number = comparater ^ number;
                comparater = 1 << 24;
                number = comparater | number;
            }
            else
            {
                comparater = 1 << 3;
                number = comparater | number;
                comparater = 1 << 24;
                number = comparater ^ number;
            }
        }
        
        comparater = 1 << 4;
        bitcomp1 = number & comparater;
        comparater = 1 << 25;
        bitcomp2 = number & comparater;  // Razmqna 4 s 25 bit
        
        if ((bitcomp1 & number) != (bitcomp2 & number))
        {
            if ((bitcomp1 & number) == 1) //ako 4tiq bit e 1 to drugiq e 0
            {
                comparater = 1 << 4;
                number = comparater ^ number;
                comparater = 1 << 25;
                number = comparater | number;
            }
            else
            {
                comparater = 1 << 4;
                number = comparater | number;
                comparater = 1 << 25;
                number = comparater ^ number;
            }
        
        }
        comparater = 1 << 5;
        bitcomp1 = number & comparater;
        comparater = 1 << 26;
        bitcomp2 = number & comparater;
        
        if ((bitcomp1 & number) != (bitcomp2 & number))
        {
            if ((bitcomp1 & number) == 1) //ako 5tiq bit e 1 to drugiq e 0
            {
                comparater = 1 << 5;
                number = comparater ^ number;
                comparater = 1 << 26;
                number = comparater | number;
            }
            else 
            {
                comparater = 1 << 5;
                number = comparater | number;
                comparater = 1 << 26;
                number = comparater ^ number;
            }
        }
        
        Console.WriteLine(number);
    }
}
