//Search a 2D Matrix - Leetcode 74
namespace DSA.BinarySearch
{
    public class Solution3
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int l = 0, h = m * n - 1;
            while (l <= h)
            {
                int mid = (h - l) / 2 + l;
                int row = mid / n, col = mid % n;
                if (matrix[row][col] == target) return true;
                else if (matrix[row][col] < target) l = mid + 1;
                else h = mid - 1;
            }

            return false;
        }
    }
}