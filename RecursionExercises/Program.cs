using System;
using RecursionExercises;
// Top-level statements
var calculator = new FactorialCalculator();
int result = calculator.Factorial(5);
Console.WriteLine("Factorial is: " + result);

FibanacciGenerator fibanacciGenerator = new();
Console.WriteLine(fibanacciGenerator.Fibonacci(5));

class FactorialCalculator
{
    public int Factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }
}
