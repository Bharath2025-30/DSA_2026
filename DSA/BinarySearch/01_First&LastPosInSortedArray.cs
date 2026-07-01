// Find First and Last Position of Element in Sorted Array - Leetcode 34
namespace DSA.BinarySearch
{
    public class Solution1
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] ans = new int[2];
            int l = 0, h = nums.Length - 1;
            ans[0] = ans[1] = -1;

            while (l <= h)
            {
                int mid = (h - l) / 2 + l;
                if (nums[mid] == target)
                {
                    ans[0] = mid;
                    h = mid - 1;
                }
                else if (nums[mid] > target)
                {
                    h = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            if (ans[0] == -1) return ans; //Target not found

            l = 0; h = nums.Length - 1;
            while (l <= h)
            {
                int mid = (h - l) / 2 + l;
                if (nums[mid] == target)
                {
                    ans[1] = mid;
                    l = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    h = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return ans;
        }
    }
}