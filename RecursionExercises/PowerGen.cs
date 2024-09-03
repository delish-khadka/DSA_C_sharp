using System;

namespace RecursionExercises;

public class PowerGen
{
    public int PowerOfNum(int num, int power){
        if(power == 0){
            return 1;
        }
        return num * PowerOfNum(num, power -1);
    }
}
