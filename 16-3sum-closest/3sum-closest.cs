public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        
            Array.Sort(nums);
            var closetSum = nums[0] + nums[1] + nums[2];
            int minDiff = Math.Abs(closetSum - target);

            for(int i = 0; i < nums.Length -2; i ++)
            {
                var left = i + 1;
                var right = nums.Length - 1;

                while(left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    var diff = Math.Abs(sum - target);
                    if(diff < minDiff)
                    {
                        closetSum = sum;
                        minDiff = diff;
                    }
                    if(sum < target)
                        left ++; 
                    else if (sum > target)
                        right--;
                    else
                        return sum;
                }

            }

            return closetSum;
    }
}