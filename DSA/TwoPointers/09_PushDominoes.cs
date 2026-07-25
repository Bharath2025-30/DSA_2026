//Push Dominoes - Leetcode 838
 
namespace DSA.TwoPointers
{
    public class Solution9 {
        public string PushDominoes(string dominoes) {
            int n = dominoes.Length;
            var arr = dominoes.ToCharArray();
            int[] rightClosestL = new int[n];
            int[] leftClosestR = new int[n];

            rightClosestL[0] = (dominoes[0] == 'R') ? 0 : -1;
            leftClosestR[n-1] = (dominoes[n-1] == 'L') ? n-1 : -1;

            for(int i=1;i<n;i++){
                if(dominoes[i] == 'R') rightClosestL[i] = i;
                else if(dominoes[i] == '.') rightClosestL[i] = rightClosestL[i-1];
                else rightClosestL[i] = -1;
            }

            for(int i=n-2;i>=0;i--){
                if(dominoes[i] == 'L') leftClosestR[i] = i;
                else if(dominoes[i] == '.') leftClosestR[i] = leftClosestR[i+1];
                else leftClosestR[i] = -1;
            }

            for(int i=0;i<n;i++){
                if(leftClosestR[i] == -1 && rightClosestL[i] == -1) arr[i] = '.';
                else{
                    if(leftClosestR[i] == -1) arr[i] = 'R';
                    else if(rightClosestL[i] == -1) arr[i] = 'L';
                    else{
                        int netLeftDist = Math.Abs(i-leftClosestR[i]);
                        int netRightDist = Math.Abs(i-rightClosestL[i]);
                        if(netLeftDist < netRightDist) arr[i] = 'L';
                        else if(netRightDist < netLeftDist) arr[i] = 'R';
                        else arr[i] = '.';
                    }
                }
            }

            return new string(arr);
        }
    }
}