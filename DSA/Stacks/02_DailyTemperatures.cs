//Daily Temperatures -- Leetcode 739
namespace DSA.Stacks
{
    public class Solution2 {
        public int[] DailyTemperatures(int[] temperatures) {
            //Monotonic Stack
            Stack<(int temp, int days)> st = new();
            int[] dailyTemps = new int[temperatures.Length];
            for(int i=temperatures.Length-1;i>=0;i--){
                int days = 1;
                while(st.Count > 0 && st.Peek().temp <= temperatures[i]){
                    days += st.Pop().days;
                }

                dailyTemps[i] = st.Count > 0 ? days : 0;
                if(st.Count > 0 ) st.Push((temperatures[i],days));
                else st.Push((temperatures[i],0));
            }
            return dailyTemps;
        }
    }
}