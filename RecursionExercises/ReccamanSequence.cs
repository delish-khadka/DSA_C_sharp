using System;
using System.Collections.Generic;

namespace RecursionExercises
{
    public class ReccamanSequence
    {
        // Recursive method to calculate the nth term of the Recaman sequence.
        // Takes an integer n and a HashSet<int> to track seen values.
        public int ReccamanSequenceNumber(int n, HashSet<int> seen)
        {
            // Base case: a(0) = 0
            if (n == 0)
            {
                // Add the initial value to the HashSet
                seen.Add(0);
                return 0;
            }

            // Recursively calculate the previous term a(n-1)
            int previous = ReccamanSequenceNumber(n - 1, seen);
            
            // Attempt to subtract `n` from the previous term
            int next = previous - n;
            
            // Check if the result is positive and hasn't been seen before
            if (next > 0 && !seen.Contains(next))
            {
                // Add the result to the HashSet and return it
                seen.Add(next);
                return next;
            }
            else
            {
                // If subtraction isn't valid, add `n` instead
                next = previous + n;
                seen.Add(next);
                return next;
            }
        }
    }
}
