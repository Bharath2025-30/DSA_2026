//Evaluate Reverse Polish Notation -- Leetcode 150
namespace DSA.Stacks
{
    public class Solution10 {
        public int EvalRPN(string[] tokens) {
            Stack<int> st = new();
            foreach(var val in tokens){
                if(val == "+" || val == "-" || val == "*" || val == "/"){
                    int op2 = st.Pop();
                    int op1 = st.Pop();
                    int res = val switch {
                        "+" => op1 + op2,
                        "-" => op1 - op2,
                        "*" => op1 * op2,
                        "/" => op1 / op2,
                        _   => throw new InvalidOperationException()
                    };
                    st.Push(res);
                }
                else{
                    st.Push(int.Parse(val));
                }
            }

            return st.Peek();
        }
    }
}