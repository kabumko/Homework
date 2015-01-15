using System;
/*
   Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
   Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
   Note: You may need to use for-loops (learn in Internet how). 
 */
class PrintTheASCIITable
{
    static void Main()
    {
        char asciiElement = '0';
        for (int i = 0; i <= 255; i++) 
        {
            Console.Write(asciiElement + " ");
            asciiElement++;
            if (i % 10 == 0) 
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine("255 znaka");
    }
}
