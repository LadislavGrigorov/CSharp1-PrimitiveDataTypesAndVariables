using System;
//9.Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

class CopyRightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("  \u00A9");
        Console.WriteLine(" \u00A9\u00A9\u00A9");
        Console.WriteLine("\u00A9\u00A9\u00A9\u00A9\u00A9");

    }
}
