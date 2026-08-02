//Remove All Adjacent Duplicates In String -- Leetcode 1047
using System.Text;

namespace DSA.Stacks
{
    public class Solution6 {
        public string RemoveDuplicates(string s) {
            Stack<char> st = new();
            for(int i=s.Length-1;i>=0;i--){
                if(st.Count == 0 || st.Peek() != s[i]) st.Push(s[i]);
                else st.Pop();
            }

            StringBuilder str = new StringBuilder();
            while(st.Count > 0){
                str.Append(st.Pop());
            }

            return str.ToString();
        }
    }
}