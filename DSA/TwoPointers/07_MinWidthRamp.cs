//Maximum Width Ramp - Leetcode 962
 
namespace DSA.TwoPointers
{
    public class Solution7 {
        public int MaxWidthRamp(int[] nums) {
            int n = nums.Length;
            int[] rightMax = new int[n];
            rightMax[n-1] = nums[n-1];

            for(int i=n-2;i>=0;i--){
                rightMax[i] = Math.Max(nums[i], rightMax[i+1]);
            }

            int l=0, r= 0;
            int ramp = 0;
            while(r<n){
                while(l < r && nums[l] > rightMax[r]) l++;
                ramp = Math.Max(ramp, r-l);
                r++;
            }

            return ramp;
        }
    }
}