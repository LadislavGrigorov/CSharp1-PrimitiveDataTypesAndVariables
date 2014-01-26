using System;
//11.Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

class ExchangeValuesOf2Variables
{
    static void Main()
    {
        decimal firstValue = 5m;
        decimal secondValue = 10m;
        firstValue = firstValue * secondValue;
        secondValue = firstValue / secondValue;
        firstValue = firstValue / secondValue;
        Console.WriteLine("First value = {0}, Second Value = {1}", firstValue, secondValue);

    }
}
