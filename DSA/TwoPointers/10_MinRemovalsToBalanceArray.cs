//Minimum Removals to Balance Array - Leetcode 3364
 
namespace DSA.TwoPointers
{
    public class Solution10 {
        public int MinRemoval(int[] nums, int k) {
            Array.Sort(nums);
            int i=0,j=0,maxBalencedArr=0;
            while(j < nums.Length){
                while((long)nums[j] > (long)k*nums[i]){
                    i++;
                }
                maxBalencedArr = Math.Max(maxBalencedArr, j-i+1);
                j++;
            }

            int minNoOfDeletions = nums.Length - maxBalencedArr;
            return minNoOfDeletions;
        }
    }
}