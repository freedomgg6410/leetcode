public class Solution {
    public bool IsAnagram(string s, string t) {
        
        var arrayS = s.ToArray();
        var arrayT = t.ToArray();
        Array.Sort(arrayS);
        Array.Sort(arrayT);

        return new string(arrayS) == new string(arrayT);
    }
}