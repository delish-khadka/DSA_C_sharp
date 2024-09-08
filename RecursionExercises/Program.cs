using System;
using RecursionExercises;
// Top-level statements
// var calculator = new FactorialCalculator();
// int result = calculator.Factorial(5);
// Console.WriteLine("Factorial is: " + result);

// FibanacciGenerator fibanacciGenerator = new();
// Console.WriteLine(fibanacciGenerator.Fibonacci(5));

// ReccamanSequence reccamanSequence = new ReccamanSequence();
// int recc = reccamanSequence.ReccamanSequenceNumber(5,new HashSet<int>());
// Console.WriteLine(recc);

// PowerGen powerGen= new PowerGen();
// int testPow = powerGen.PowerOfNum(5,3);
// Console.WriteLine(testPow);
TowersOfHanoiClass.SolveHanoi(2,'A','C','B');

class FactorialCalculator
{
    public int Factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
    }
}
