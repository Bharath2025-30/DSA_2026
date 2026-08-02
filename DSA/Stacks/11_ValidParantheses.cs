//Valid Parentheses -- Leetcode 20
namespace DSA.Stacks
{
    public class Solution11 {
        public bool IsValid(string s) {
            Stack<int> st = new Stack<int>();
            for(int i=0;i<s.Length;i++){
                if(s[i] == '(' || s[i] == '{' || s[i] == '[') st.Push(s[i]);
                else{
                    if(s[i] == ')' && st.Count > 0 && st.Peek() == '(') st.Pop();
                    else if(s[i] == ']' && st.Count > 0 && st.Peek() == '[') st.Pop();
                    else if(s[i] == '}' && st.Count > 0 && st.Peek() == '{') st.Pop();
                    else{
                        return false;
                    }
                }
            }

            return st.Count == 0;
        }
    }
}