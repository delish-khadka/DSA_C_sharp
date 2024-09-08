using System;

namespace RecursionExercises;

public class TowersOfHanoiClass
{
    public static void SolveHanoi(int n, char fromPeg, char toPeg, char auxPeg)
    {
        // Base case: if only one disk, move it from fromPeg to toPeg
        if (n == 1)
        {
            Console.WriteLine("Move disk 1 from " + fromPeg + " to " + toPeg);
            return;
        }
        
        // Move n-1 disks from fromPeg to auxPeg using toPeg as auxiliary
        SolveHanoi(n - 1, fromPeg, auxPeg, toPeg);
        
        // Move the nth (largest) disk from fromPeg to toPeg
        Console.WriteLine("Move disk " + n + " from " + fromPeg + " to " + toPeg);
        
        // Move the n-1 disks from auxPeg to toPeg using fromPeg as auxiliary
        SolveHanoi(n - 1, auxPeg, toPeg, fromPeg);
    }
}

