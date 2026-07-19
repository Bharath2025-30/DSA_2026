// Find Minimum in Rotated Sorted Array II - Leetcode 154 

namespace DSA.BinarySearch
{
    public class Solution50 {
        public int FindMin(int[] nums) {
            int n = nums.Length;
            int l = 0, h = n-1;

            while(l < h){
                int mid = (h-l)/2 + l;
                if(nums[l] < nums[h]){
                    return nums[l];
                }

                if(nums[mid] > nums[h]){
                    l = mid+1;   //Ans lies on right half
                }
                else if(nums[mid] == nums[h]){
                    h--;        //Basically shrinking search space to explore remaining elements again.
                }
                else{
                    h = mid;    //Our mid can be an ans
                }
            }

            return nums[l];
        }
    }
}