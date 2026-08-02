// Basic Calculator HARD -- Leetcode 224
namespace DSA.Stacks
{
    public class Solution8 {
    public int Calculate(string s) {
        int num = 0, sign = 1, res = 0;
        Stack<int> st = new();

        for(int i=0;i<s.Length;i++){
            //digit
            if(s[i] >= '0' && s[i] <= '9'){
                // 1. update the num
                num = num * 10 + (s[i]-'0');
            }
            else if(s[i] == '+' || s[i] == '-'){
                // 1. update the result
                // 2. update the sign & reset num
                res += num * sign;
                sign = (s[i] == '+') ? 1 : -1;
                num = 0;
            }
            else if(s[i] == '('){
                // 1. push cur res & then sign into stack
                // 2. reset num, sign, res
                st.Push(res);
                st.Push(sign);
                num = 0; res = 0; sign = 1;
            }
            else if(s[i] == ')'){
                // 1. update the res to get the value within (...)
                // 2. pop the sign & multiply with existing res
                // 3. pop the earlier result & update the res
                // 4. Update the number, sign
                res += num * sign;
                res *= st.Pop();
                res += st.Pop();
                num = 0; sign = 1;
            }
        }

        res += (num * sign);

        return res;
    }
}
}