using System;
/*
    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
 */
class NullValuesArithmetic
{
    static void Main()
    {
        int? nullableInt = null;
        double? nullableDouble = null;
        Console.WriteLine(nullableInt + " " + nullableDouble);
        Console.WriteLine(nullableInt + "1" + nullableDouble);
        nullableDouble = 7; nullableInt = null + 17;  /*Dava greshka tuk che vinagi rezultata shte e null*/
        Console.WriteLine(nullableInt + " " + nullableDouble);
        nullableDouble = 7; nullableInt = 17;
        Console.WriteLine(nullableInt + " " + nullableDouble);
    }
}

