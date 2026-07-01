//Kth Missing Positive Number - Leetcode 1539
namespace DSA.BinarySearch
{
    public class Solution8 {
        public int FindKthPositive(int[] arr, int k) {
            int l = 0, h = arr.Length-1;
            while(l <= h){
                int mid = (h-l)/2 +l ;
                if(arr[mid] - mid - 1 < k) l = mid+1;
                else h = mid-1;
            }

            return l+k;
        }
    }
}