﻿using System;
//2.Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

class FloatAssign
{
    static void Main()
    {
        double a = 43.567839023d;
        float b = 12.345f;
        double c = 8923.1234857d;
        float d = 3456.091f;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", a, b, c, d);
    }
}
