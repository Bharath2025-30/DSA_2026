// Find the Lexicographically Largest String From the Box I - Leetcode 3403

//Note: Need to Revise and Upsolve Leetcode 1163 for intution behind two pointer approach
 
namespace DSA.TwoPointers
{
    public class Solution14 {
        public string AnswerString(string word, int numFriends) {
            //Approach1: BruteForce
            int n = word.Length;
            if(numFriends == 1) return word;
            int maxPossibleString = n - (numFriends-1);
            string ans = "";
            for(int i=0;i<n;i++){
                int actualPossLen = Math.Min(maxPossibleString, n-i);
                ans = string.Compare(ans, word.Substring(i,actualPossLen)) < 0 ? word.Substring(i,actualPossLen) : ans;
            }
            return ans;
        }

    }
}