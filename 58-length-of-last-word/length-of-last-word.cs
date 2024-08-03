public class Solution {
    public int LengthOfLastWord(string s) {
        var str = s.Trim().Split(' ');
        var result = str[str.Length-1];
        return result.Trim().Length;
    }
}