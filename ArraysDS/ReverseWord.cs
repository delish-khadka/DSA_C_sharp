public class ReverseWord{
    public string ReverseString(string word){
        char[] chars = word.ToCharArray();
        string rev_word = "";
        foreach(char s in chars){
            rev_word = s + rev_word;
        }
        return rev_word;

    }
}