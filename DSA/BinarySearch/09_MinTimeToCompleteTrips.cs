// Minimum Time to Complete Trips - Leetcode 2187
namespace DSA.BinarySearch
{
    public class Solution9 {
        private static bool IsPossible(int[] time, int totalTrips, long minTime){
            long trips = 0;
            for(int i=0;i<time.Length;i++){
                trips += minTime/(long)time[i];
            }

            return trips >= (long)totalTrips;
        }
        public long MinimumTime(int[] time, int totalTrips) {
            long l = time.Min(), h = l * totalTrips;
            long ans = totalTrips;
            while(l <= h){
                long mid = (h-l)/2 + l;
                if(IsPossible(time,totalTrips,mid)){
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