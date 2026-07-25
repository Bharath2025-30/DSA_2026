//Minimum Length of String After Deleting Similar Ends - Leetcode 1750
 
namespace DSA.TwoPointers
{
    public class Solution6 {
        public int MinimumLength(string s) {
            int i=0, j=s.Length-1;
            while(i < j && s[i] == s[j]){
                char ch = s[i];
                while(i < j && ch == s[i]) i++;
                while(j >= i && ch == s[j]) j--;
            }

            return j-i+1;
        }
    }
} 