public class Solution {
    public string ReverseWords(string s) {
        var a = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for(int i = 0 ; i <  a.Length/2; i++)
        {
            (a[i], a[a.Length - 1 - i]) = (a[a.Length - 1 - i], a[i]);
        }
        return string.Join(" ", a);
        
    }
}