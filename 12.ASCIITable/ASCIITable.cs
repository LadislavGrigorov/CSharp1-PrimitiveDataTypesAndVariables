﻿using System;
//12. Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

class ASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 128; i++)
        {
            Console.WriteLine("{0} - {1}", i, (char)i);
        }
    }
}
