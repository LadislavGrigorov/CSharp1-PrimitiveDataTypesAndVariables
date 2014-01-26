using System;
class CompareFloatingNumbers
{
    static void Main()
    {
        float firstNumber = 5.00000001f;
        float secondNumber = 5.00000003f;
        bool areEqual = firstNumber == secondNumber;
        Console.WriteLine(areEqual);
    }
}
