using System;
/*
    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.    Check.
 */
class DeclareVariables
{
    static void Main()
    {
        ushort purvaPromenliva = 52130;
        sbyte vtoraPromenliva = -115;
        int tretaPromenliva = 4825932;
        byte chetvurtaPromenliva = 97;
        short petaPromenliva = -10000;
        Console.WriteLine("ushshort promenliva = {0} \n sbyte proemnliva = {1} \n int promenliva = {2} \n byte promenliva = {3} \n short promenliva = {4}", purvaPromenliva, vtoraPromenliva, tretaPromenliva, chetvurtaPromenliva, petaPromenliva);
    }
}
