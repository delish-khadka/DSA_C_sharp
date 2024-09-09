using System;

namespace RecursionExercises;

public class ExercisesCollection
{
    public static int SumOfDigits(int value){
        if(value < 0){
            throw new ArgumentOutOfRangeException("Not valid");
        }
        if(value == 0){
            return 0;
        }
        
        return value % 10 + SumOfDigits(value / 10);

    }

    public string PermutationOfString(string data){
        return "";
    }
}
