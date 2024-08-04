public class Solution {
   public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
        if (strs.Length == 1) return strs[0];

        // Start with the entire first string as the prefix
        string prefix = strs[0];

        // Compare the prefix with each string in the array
        for (int i = 1; i < strs.Length; i++) {
            while (strs[i].IndexOf(prefix) != 0) {
                // Reduce the prefix length until a match is found
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "") return ""; // No common prefix
            }
        }
        
        return prefix;
    }
}