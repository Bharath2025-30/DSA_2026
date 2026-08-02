//Removing Stars From a String -- Leetcode 2390
using System.Text;

namespace DSA.Stacks
{
    public class Solution12 {
        public string RemoveStars(string s) {
            //Approach1: Using Stack
            // Stack<char> st = new();
            // foreach(char ch in s){
            //     if(ch != '*') st.Push(ch);
            //     else{
            //         if(st.Count > 0) st.Pop();
            //     }
            // }

            // StringBuilder str = new StringBuilder();

            // while(st.Count > 0){
            //     str.Append(st.Pop());
            // }

            // string res = new string(str.ToString().Reverse().ToArray());
            // return res;

            //Approach2: Linear Traversal
            //Generating string using StringBuilder
            StringBuilder str = new StringBuilder();
            for(int i=0;i<s.Length;i++){
                if(s[i] != '*'){
                    str.Append(s[i]);
                }
                else{
                    str.Length--;
                }
            }

            return str.ToString();
        }
    }
}