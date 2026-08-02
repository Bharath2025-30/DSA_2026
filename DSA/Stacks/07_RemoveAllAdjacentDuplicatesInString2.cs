//Remove All Adjacent Duplicates in String II -- Leetcode 1209
using System.Text;

namespace DSA.Stacks
{
    public class Solution7 {
    public string RemoveDuplicates(string s, int k) {
        Stack<(char ch, int cnt)> st = new();
        for(int i=s.Length-1;i>=0;i--){
            if(st.Count == 0 || st.Peek().ch != s[i]) st.Push((s[i], 1));
            else{
                int cnt = st.Pop().cnt;
                if(cnt < k-1) st.Push((s[i],cnt+1));
            }
        }

        StringBuilder str = new();

        while(st.Count > 0){
            var ele = st.Pop();
            str.Append(ele.ch, ele.cnt);
        }

        return str.ToString();
    }
}
}