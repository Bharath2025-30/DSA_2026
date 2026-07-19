//Boats to Save People - Leetcode 881
namespace DSA.TwoPointers
{
        public class Solution4 {
        public int NumRescueBoats(int[] people, int limit) {
            int n = people.Length;
            int boats = 0;
            Array.Sort(people);
            int i=0,j=n-1;
            while(i <= j){
                if(people[i] + people[j] <= limit){
                    i++;j--;
                }
                else{
                    j--;
                }
                boats++;
            }

            return boats;
        }
    }
}