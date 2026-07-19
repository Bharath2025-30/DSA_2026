// Minimum Initial Energy to Finish Tasks - Leetcode 1665

namespace DSA.BinarySearch
{
    public class Solution {
        private static bool IsPossible(int[][] tasks, int minEnergy){
            int n = tasks.Length;
            Console.WriteLine(minEnergy);
            for(int i=0;i<n;i++){
                if(minEnergy < tasks[i][1]) return false;
                minEnergy -= tasks[i][0];
            }

            return true;
        }
        public int MinimumEffort(int[][] tasks) {
            Array.Sort(tasks, (a, b) => (b[1] - b[0]).CompareTo(a[1] - a[0]));

            int totActualEnergy = 0, totMinEnergy = 0;
            for(int i=0;i<tasks.Length;i++){
                Console.WriteLine(tasks[i][0] + " " + tasks[i][1]);
                totActualEnergy += tasks[i][0];
                totMinEnergy += tasks[i][1];
            }

            int l = totActualEnergy, h = Math.Max(totActualEnergy, totMinEnergy);
            Console.WriteLine(l + " " + h);
            int ans = h;
            while(l <= h){
                int mid = (h-l)/2 + l;
                if(IsPossible(tasks, mid)){
                    ans = mid;
                    h = mid-1;
                }
                else{
                    l = mid+1;
                }
            }

            return ans;
        }
    }
}