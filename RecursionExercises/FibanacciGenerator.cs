using System;

namespace RecursionExercises;

public class FibanacciGenerator
{
    public int Fibonacci(int count){
        if(count <= 1){
            return count;
        }
        return Fibonacci(count - 1) + Fibonacci(count-2);
    }
}
