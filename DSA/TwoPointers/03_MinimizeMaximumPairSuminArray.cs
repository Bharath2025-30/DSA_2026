//Minimize Maximum Pair Sum in Array - Leetcode 1877

namespace DSA.TwoPointers
{
    public class Solution3 {
        public int MinPairSum(int[] nums) {
            Array.Sort(nums);
            int i=0,j=nums.Length-1;
            int ans = 0;
            while(i < j){
                ans = Math.Max(ans, nums[i++]+nums[j--]);
            }

            return ans;
        }
    }
}