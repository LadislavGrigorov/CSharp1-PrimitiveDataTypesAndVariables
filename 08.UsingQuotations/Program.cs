using System;
//8.Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings.

class Program
{
    static void Main()
    {
        string firstQuotation = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstQuotation);
        string secondQuotation = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(secondQuotation);
    }
}
