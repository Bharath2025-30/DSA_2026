// Maximum Distance Between a Pair of Values - Leetcode 1855
 
namespace DSA.TwoPointers
{
    public class Solution13 {
        public int MaxDistance(int[] nums1, int[] nums2) {
            int i=0,j=0, ans = 0;
            while(i < nums1.Length && j < nums2.Length){
                if(i <= j && nums1[i] <= nums2[j]){
                    ans = Math.Max(ans, j-i);
                    j++;
                }
                else if(i > j) j++;
                else i++;
            }

            return ans;
        }
    }
}