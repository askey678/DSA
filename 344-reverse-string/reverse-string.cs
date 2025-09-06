public class Solution {
    public void ReverseString(char[] s) {
        var count = s.Length - 1;
        for(int i = 0; i <= count/2; i++)
        {
            var a= s[i];
            s[i] = s[count - i];
            s[count - i] = a;
        }
    }
}