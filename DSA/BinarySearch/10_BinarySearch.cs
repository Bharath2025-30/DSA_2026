// Binary Search - Recursive & Iterative Solutions - Leetcode 704

namespace DSA.BinarySearch {
    public class Solution10 {
        private static int Solve(int[] nums, int target, int l, int h){
            if(l > h) return -1;
            int mid = (h-l)/2 + l;
            int ans = -1;
            if(nums[mid] == target){ 
                ans = mid;
            }
            else if(nums[mid] < target){
                ans = Solve(nums,target,mid+1,h);
            }
            else{
                ans = Solve(nums,target,l,mid-1);
            }

            return ans;
        }

        
        public int Search(int[] nums, int target) {

            //Iterative:
            // int l = 0, h = nums.Length-1;
            // while(l <= h){
            //     int mid = (h-l)/2 + l;
            //     if(nums[mid] == target) return mid;
            //     else if(target < nums[mid]) h = mid-1;
            //     else l = mid+1;
            // }

            // return -1;

            //Recursive:
            return Solve(nums,target,0,nums.Length-1);
        }
    }
}