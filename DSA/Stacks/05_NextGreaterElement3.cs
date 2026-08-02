// Next Greater Element III -- Leetcode 556
namespace DSA.Stacks
{
    public class Solution5 {
        public int NextGreaterElement(int n) {
            //Approach: Next Permutation Question - Not Related to STACKS
            var str = n.ToString().ToCharArray();
            int i = str.Length-2;
            int res = -1;
            
            while(i >= 0 && str[i] >= str[i+1]){
                i--;
            }   

            if(i == -1){
                Array.Reverse(str);
                if(int.TryParse(new string(str), out res))
                {
                    return (res > n) ? res : -1;
                }
                return -1;
            }

            int j = str.Length-1;
            while(j >= 0 && str[j] <= str[i]){
                j--;
            }

            // swap
            char temp = str[i];
            str[i] = str[j];
            str[j] = temp;

            // reverse suffix
            Array.Reverse(str, i+1, str.Length-(i+1));

            if(int.TryParse(new string(str), out res))
            {
                return res > n ? res : -1;
            }

            return -1;
        }
    }
}