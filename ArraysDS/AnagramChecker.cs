using System;

namespace ArraysDS;

public class AnagramChecker
{
    public bool IsAnagram(string word1, string word2){
        if (word1.Length != word2.Length){
            return false;
        }
        Dictionary<char, int> check1 = new Dictionary<char, int>();
        Dictionary<char, int> check2 = new Dictionary<char, int>();

        foreach(char c in word1){
            if (check1.ContainsKey(c)){
                check1[c]++;
            }
            else{
                check1[c] = 1;
            }
        }
        foreach(char d in word2){
            if (check2.ContainsKey(d)){
                check2[d]++;
            }
            else{
                check2[d] = 1;
            }
        }
        
        foreach(var pair in check1){
            if(!check2.ContainsKey(pair.Key) || check2[pair.Key] != pair.Value){
                return false;
            }
        }
        return true;
    }
}
