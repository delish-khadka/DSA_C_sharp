using System;

namespace ArraysDS;

public class FirstNonRepeatedCharacterInString
{
    public char FirstNonRepeatedChar(string word){
        if(string.IsNullOrEmpty(word)){
            return '\0';
        }
        Dictionary<char,int> characterStorage = new Dictionary<char,int>();
        foreach(char c in word){
            if(!characterStorage.ContainsKey(c)){
                characterStorage[c] = 1;
            }
            else{
                characterStorage[c]++;
            }
        }
        foreach(char c in word){
            if (characterStorage[c] == 1){
                return c;
            }
        }
        return '\0';
    }
}
