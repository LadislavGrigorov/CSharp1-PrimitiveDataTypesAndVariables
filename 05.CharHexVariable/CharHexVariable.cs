﻿using System;
//5.Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

class CharHexVariable
{
    static void Main()
    {
        char symbol = '\u0048';
        Console.WriteLine(symbol);
    }
}
