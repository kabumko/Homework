using System;
/*
    Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
    Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */
class FloatOrDouble
{
    static void Main()
    {
        float fVariable = 12.345f;
        double dVariable = 12.345;
        Console.WriteLine("Float moje da e ravno na 12.345: {0}\nDouble moje da e ravno na 12.345: {1} ", fVariable, dVariable);
        fVariable = 3456.091f;
        dVariable = 3456.091;
        Console.WriteLine("Float moje da e ravno na 3456.091: {0}\nDouble moje da e ravno na 3456.091: {1} ", fVariable, dVariable);
        fVariable = 8923.1234857f;
        dVariable = 8923.1234857;
        Console.WriteLine("Float NE moje da e ravno na 8923.1234857: {0}\nDouble moje da e ravno na 8923.1234857: {1} ", fVariable, dVariable);
        fVariable = 34.567839023f;
        dVariable = 34.567839023;
        Console.WriteLine("Float NE moje da e ravno na 34.567839023: {0}\nDouble moje da e ravno na 34.567839023: {1} ", fVariable, dVariable);
    }
}
