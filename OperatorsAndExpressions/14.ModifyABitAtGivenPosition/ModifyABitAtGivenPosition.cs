using System;
// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int variableIntN = int.Parse(Console.ReadLine());
        Console.Write("Enter p:   ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter v - 1 or 0  : ");
        int v = int.Parse(Console.ReadLine());
        int sravnqtor = 1 << p;
        int spasitelN = variableIntN;
        int dali = variableIntN & sravnqtor;
        // ako v e 1
        if (v == 1)
        {   
            // i ako bita na tova mqsto e 1 ne promenqme nishto i printim sushtoto
            if (dali == 1)
            {
                Console.WriteLine("Rezultat:   {0}", variableIntN);
            }
            // ako bita obache e 0 a v e 1 gi subirame s ogichesko ili - "|"
            else 
            {
                spasitelN = variableIntN | sravnqtor;
                Console.WriteLine("Rezultat:   {0}", spasitelN);
            }
        }
        // no ako v e 0
        else 
        {
            // ako bita e 1 a v 0, zanulqvame ednakvite s - "^"
            if (dali == 1)
            {
                spasitelN = variableIntN ^ sravnqtor;
                Console.WriteLine("Rezultat:   {0}", spasitelN);
            }
            // ako bita e 0 a v e 0 ne promenqme
            else
            {
                Console.WriteLine("Rezultat:   {0}", variableIntN);
            }
        }
    }
}
