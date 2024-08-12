using System;

namespace ArraysDS;

public class FindDuplicates
{
    public HashSet<int> DuplicatesHashSet(int[] Arr){

        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>(); 

        foreach (int number in Arr) {
            if(!seen.Contains(number)){
                seen.Add(number);
            }
            else{
                duplicates.Add(number);
            }
            
        }
        return duplicates;
    }
    public IEnumerable<int> DuplicatesUsingLINQ(int[] Arr){
        var duplicates = Arr.GroupBy(x=>x)
                            .Where(s=>s.Count()>1)
                            .Select(g=> g.Key);
        return duplicates;
    }
    public int[] DuplicateUsingDictionary(int[] Arr){
        Dictionary<int, int> keyValuePairs= new Dictionary<int, int>();
        List<int> duplicates= new List<int>();

        foreach(int i in Arr){
            if(!keyValuePairs.ContainsKey(i)){
                keyValuePairs[i] = 1;
            }
            else{
                // keyValuePairs[i] = keyValuePairs[i] + 1;
                // if (keyValuePairs[i] == 2){
                //     duplicates.Add(i);

                // }
                duplicates.Add(i);
            }
        }
        return duplicates.ToArray();
    }
}
