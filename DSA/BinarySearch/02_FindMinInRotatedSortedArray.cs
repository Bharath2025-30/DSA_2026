// Find Minimum in Rotated Sorted Array - Leetcode 153
namespace DSA.BinarySearch
{
    public class Solution2
    {
        public int FindMin(int[] nums)
        {
            int l = 0, h = nums.Length - 1;
            while (l < h)
            {
                int mid = (h - l) / 2 + l;
                if (nums[mid] >= nums[h])
                {
                    l = mid + 1;
                }
                else h = mid;
            }

            return nums[l];
        }
    }
}