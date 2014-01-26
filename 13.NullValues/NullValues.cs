using System;
//13.Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

class NullValues
{
    static void Main()
    {
        int? nullInteger = null;
        double? nullDouble = null;
        Console.WriteLine("Null values of integer and double - {0}, {1}", nullInteger, nullDouble);
        nullInteger = 1;
        nullDouble = 3.5;
        Console.WriteLine("Integer number - {0}, double number - {1}", nullInteger, nullDouble);
    }
}
