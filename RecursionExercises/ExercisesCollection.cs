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

    public static void FindPermutations(string str, string prefix)
    {
        if (str.Length == 0)
        {
            Console.WriteLine(prefix);  // Base case: print the current permutation
        }
        else
        {
            for (int i = 0; i < str.Length; i++)
            {
                // Remove the ith character and recursively find permutations of the remaining string
                string rem = str.Substring(0, i) + str.Substring(i + 1);
                FindPermutations(rem, prefix + str[i]);
            }
        }
    }

}
