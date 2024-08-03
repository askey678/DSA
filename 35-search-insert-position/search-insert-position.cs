public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var count = 0;
       foreach(var item in nums)
       {
            if(item == target)
                return count;
            else if(target < item)
                return count;
            else
                count++;
       }
       return nums.Length;
    }
}