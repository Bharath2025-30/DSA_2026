//Find the rotation count in rotated sorted array - GFG
namespace DSA.BinarySearch{
    public class Solution5 {
        public int FindKRotation(int[] arr) {
            int l = 0, h = arr.Length - 1;
            while(l < h){
                    int mid = (h - l) / 2 + l;
                if(arr[mid] >= arr[h]) l = mid+1;
                else h = mid;
            }
            
            return h;
        }
    }
}
