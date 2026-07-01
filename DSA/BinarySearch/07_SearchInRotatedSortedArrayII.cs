// Search in Rotated Sorted Array - Leetcode 33
namespace DSA.BinarySearch
{
    public class Solution7 {
        public int Search(int[] nums, int target) {
            int l = 0, h = nums.Length-1;
            while(l <= h){
                int mid = (h-l)/2 +l ;
                if(nums[mid] == target) return mid;
                if(nums[l] == nums[mid] && nums[mid] == nums[h]){
                    l++; h--; continue;
                }
                else if(nums[l] <= nums[mid]){
                    if(nums[l] <= target && target < nums[mid]) h = mid-1;
                    else l = mid+1;
                }
                else{
                    if(nums[mid] < target && target <= nums[h]) l = mid+1;
                    else h = mid-1;
                }
            }

            return -1;
        }
    }
}