//Longest Balanced Substring I - Leetcode 3713
 
namespace DSA.TwoPointers
{
    public class Solutio11 {
        private static int[] hash = new int[26];
        private static bool IsBalanced(){
            int occurrence = 0;
            for(int i=0;i<26;i++){
                if(hash[i] == 0) continue;
                if(occurrence == 0) occurrence = hash[i];
                else if(occurrence != hash[i]) return false;
            }
            return true;
        }
        public int LongestBalanced(string s) {
            int n = s.Length, ans = 0;
            for(int i=0;i<n;i++){
                for(int j=i;j<n;j++){
                    hash[s[j]-'a']++;
                    if(IsBalanced()){
                        ans = Math.Max(ans, j-i+1);
                    }
                }
                hash = new int[26];
            }
            return ans;
        }
    }
}