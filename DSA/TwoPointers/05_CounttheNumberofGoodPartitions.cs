//Count the Number of Good Partitions - Leetcode 2963
 
namespace DSA.TwoPointers
{
    public class Solution5 {
        private static int mod = (int)1e9+7;
        public int NumberOfGoodPartitions(int[] nums) {
            int n = nums.Length;
            Dictionary<int,int> map = new();
            for(int i=0;i<n;i++){
                map[nums[i]] = i;
            }

            int l = 0, r = map[nums[0]];
            int ans = 1;
            while(l < n){
                if(l > r){
                    ans = (ans * 2) % mod;
                }
                r = Math.Max(r, map[nums[l]]);
                l++;
            }

            return ans;

        }
    }
}