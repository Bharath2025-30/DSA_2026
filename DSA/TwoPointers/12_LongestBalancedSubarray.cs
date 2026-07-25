//Longest Balanced Subarray I - Leetcode 3719
 
namespace DSA.TwoPointers
{
    public class Solution {
        private static HashSet<int> set = new();
        public int LongestBalanced(int[] nums) {
            int n = nums.Length, ans = 0;
            for(int i=0;i<n;i++){
                int oddCnt = 0;
                for(int j=i;j<n;j++){
                    if(!set.Contains(nums[j])){
                        oddCnt += nums[j]%2;
                    }
                    
                    set.Add(nums[j]);
                    int evenCnt = set.Count - oddCnt;
                    if(oddCnt == evenCnt){
                        ans = Math.Max(ans,j-i+1);
                    }
                }
                set.Clear();
            }

            return ans;
        }
    }
}