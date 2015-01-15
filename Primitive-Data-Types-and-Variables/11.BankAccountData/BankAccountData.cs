using System;
/*
    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */
class BankAccountData
{
    static void Main()
    {
        string holderFName = "Zambicio", holderMName = "Sonurev", holderLName = "Dakata", bankName = "Rich Bank International", iban = "16BG245235235232", creditCard1 = "2456654224566542", creditCard2 ="1234567891011121", creditCard3 ="1121110987654321";
        decimal moneyCount = 9001000000;
        Console.WriteLine("First Name = {0}\nMiddle Name = {1}\nFamily Name = {2}\nName of the Bank = {3}\nIBAN = {4}\nMoney in the Bank = {5}\nCredit Card 1 = {6}\nCredit Card 2 = {7}\nCredit Card 3 = {8}", holderFName, holderMName, holderLName, bankName, iban, moneyCount, creditCard1, creditCard2, creditCard3);
    }
}