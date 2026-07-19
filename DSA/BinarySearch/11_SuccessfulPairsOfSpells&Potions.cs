// Successful Pairs of Spells and Potions - Leetcode 2300

namespace DSA.BinarySearch
{
    public class Solution11 {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
            int n = spells.Length;
            int m = potions.Length;

            Array.Sort(potions);

            int[] ans = new int[n];
            for(int i=0;i<n;i++){
                int l = 0, h = m-1;
                int minPotionIndexReq = -1;
                int curSpell = spells[i];
                while(l <= h){
                    int mid = (h-l)/2 + l;
                    int curPotion = potions[mid]; 
                    if((long)curSpell * (long)curPotion >= success){
                        minPotionIndexReq = mid;
                        h = mid-1;
                    }
                    else{
                        l = mid+1;
                    }
                }

                if(minPotionIndexReq != -1){
                    ans[i] = m - minPotionIndexReq;
                }
            }

            return ans;
        }
    }
}