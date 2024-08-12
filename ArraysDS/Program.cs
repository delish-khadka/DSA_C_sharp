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
        int[] arrRotate = [1,2,3,4,5];
        RotateArrayClass rotateArrayClass = new RotateArrayClass();
        int[] rotated = rotateArrayClass.RotateArray(arrRotate,6);
        Console.WriteLine(string.Join(",",rotated));
        #endregion
    }
}