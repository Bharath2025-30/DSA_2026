// Single Element in a Sorted Array - Leetcode 540
namespace DSA.BinarySearch
{
    public class Solution4 {
        public int SingleNonDuplicate(int[] nums) {
            int n = nums.Length;
            if(n == 1) return nums[0];

            int l = 0, h = n-1;
            while(l < h){
                int mid = (h-l)/2 + l;
                int left = (mid-1 >= 0) ? nums[mid-1] : -1;
                int right = (mid+1 < n) ? nums[mid+1] : -1;
                if(left != nums[mid] && right != nums[mid]) return nums[mid];
                else if(left == nums[mid]){
                    if((mid-l)%2 == 0) h = mid-2;
                    else l = mid+1;
                }
                else{
                    if((h-mid)%2 == 0) l = mid+2;
                    else h = mid-1;
                }
            }

            return nums[l];
        }
    }
}