//Number of Subsequences That Satisfy the Given Sum Condition - Leetcode 1498

namespace DSA.TwoPointers
{
        public class Solution2 {
        private static int mod = (int)1e9+7;
        public int NumSubseq(int[] nums, int target) {
            int n = nums.Length;
            int i=0,j=n-1;
            int ans = 0;

            Array.Sort(nums);

            //Since power value can go beyond int - we can precompute it earlier
            int[] power = new int[n];
            power[0] = 1;
            for(int k=1;k<n;k++){
                power[k] = (power[k-1] * 2) % mod;
            }

            while(i <= j){
                if(nums[i] + nums[j] > target){
                    j--;
                }
                else{
                    ans = (ans%mod + power[j-i] % mod) % mod;
                    i++;
                }
            }

            return ans;
        }
    }
}