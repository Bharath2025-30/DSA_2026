//Next Greater Element I -- Leetcode 496
namespace DSA.Stacks
{
    public class Solution3 {
        public int[] NextGreaterElement(int[] nums1, int[] nums2) {
            Dictionary<int,int> map = new();
            Stack<int> st = new();
            int[] arr = new int[nums2.Length];

            for(int i=nums2.Length-1;i>=0;i--){
                map[nums2[i]] = i;
                while(st.Count > 0 && st.Peek() < nums2[i]) st.Pop();
                arr[i] = (st.Count > 0) ? st.Peek() : -1;
                st.Push(nums2[i]);
            }

            //Console.WriteLine(string.Join(',',arr));

            int[] ans = new int[nums1.Length];
            for(int i=0;i<nums1.Length;i++){
                int idx = map[nums1[i]];
                ans[i] = arr[idx];
            }

            return ans;

        }
    }
}