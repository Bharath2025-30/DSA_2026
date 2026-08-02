//Next Greater Element II -- Leetcode 503
namespace DSA.Stacks
{
    public class Solution4 {
        public int[] NextGreaterElements(int[] nums) {
            Stack<int> st = new();
            for(int i=nums.Length-1;i>=0;i--){
                while(st.Count != 0 && st.Peek() <= nums[i]) st.Pop();
                st.Push(nums[i]);
            }

            int[] ans = Enumerable.Repeat(0, nums.Length).ToArray();

            for(int i=nums.Length-1;i>=0;i--){
                while(st.Count != 0 && st.Peek() <= nums[i]) st.Pop();
                ans[i] = (st.Count == 0) ? -1 : st.Peek();
                st.Push(nums[i]);
            }

            return ans;
        }
    }
}