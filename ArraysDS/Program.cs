using ArraysDS;

public class Program{
    public static void Main(string[] args){
        #region reverse word instantiation
        // ReverseWord reverseWord = new ReverseWord();
        // string reverse = reverseWord.ReverseString("hello");
        // Console.WriteLine(reverse);
        #endregion
        
        #region Duplicates of an array of integers
        // FindDuplicates findDuplicates = new FindDuplicates();
        // int[] array = {1,2,2,3,3,4,4,5,5,6,6,7,7,8};
        // foreach(int i in findDuplicates.DuplicatesHashSet(array)){
        //     Console.WriteLine(i);
        // }

        // foreach(int i in findDuplicates.DuplicatesUsingLINQ(array)){
        //     Console.WriteLine(i);
        // }

        // foreach(int i in findDuplicates.DuplicateUsingDictionary(array)){
        //     Console.WriteLine(i);

        // }
        #endregion

        #region rotation of array
        // int[] arrRotateToRight = [1,2,3,4,5];
        // int[] arrRotateToLeft = [1,2,3,4,5];
        // RotateArrayClass rotateArrayClass = new RotateArrayClass();

        // int[] rotatedToRight = rotateArrayClass.RotateArrayToRight(arrRotateToRight,3);
        // Console.WriteLine(string.Join(",",rotatedToRight));

        // int[] rotatedToLeft = rotateArrayClass.RotateArrayToLeft(arrRotateToLeft,3);
        // Console.WriteLine(string.Join(",",rotatedToLeft));
        #endregion

        #region Find first character without duplicates
        // FirstNonRepeatedCharacterInString firstNonRepeatedCharacterInString= new FirstNonRepeatedCharacterInString();
        // char first = firstNonRepeatedCharacterInString.FirstNonRepeatedChar("hhello");
        // Console.WriteLine(first);
        #endregion

        #region Anagram checker
        AnagramChecker anagramChecker = new AnagramChecker();
        var IsAnagram = anagramChecker.IsAnagram("silent","listen");
        Console.WriteLine(IsAnagram);
        #endregion
    }
}