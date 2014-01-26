using System;
//3.Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

class Program
{
    static void Main()
    {
        float firstNumber = 5.00000001f;
        float secondNumber = 5.00000003f;
        bool areEqual = firstNumber == secondNumber;
        Console.WriteLine(areEqual);
    }
} 