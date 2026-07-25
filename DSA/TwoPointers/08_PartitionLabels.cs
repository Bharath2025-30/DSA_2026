//Partition Labels - Leetcode 763
 
namespace DSA.TwoPointers
{
    public class Solution8 {
        public IList<int> PartitionLabels(string s) {
            int[] hash = new int[26];
            for(int it=0;it<s.Length;it++){
                int idx = s[it]-'a';
                hash[idx] = it;
            }

            int i=0, j=0;
            IList<int> ans = new List<int>();
            for(int k=0;k<s.Length;k++){
                if(k > j){
                    ans.Add(j-i+1);
                    i = k;
                }

                j = Math.Max(j, hash[s[k]-'a']);
            }

            ans.Add(j-i+1);
            return ans;
        }
    }
}