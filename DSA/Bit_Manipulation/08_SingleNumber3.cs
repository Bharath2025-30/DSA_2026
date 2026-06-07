namespace DSAProblems.BitManipulation
{
    public class SingleNumber3
    {
        public static int[] SingleNumber(int[] nums) {
        int xor = 0;
        foreach(int num in nums){
            xor ^= num;
        }

        int rmsb = xor & (~xor + 1);

        int res1 = 0, res2 = 0;

        foreach(int num in nums){
            if((rmsb & num) == 0){
                res1 ^= num;
            }
            else{
                res2 ^= num;
            }
        }

        int[] ans = new int[2];
        ans[0] = res1; ans[1] = res2;
        return ans;
    }
        public static void Solve()
        {
            int[] nums = {1,2,1,3,2,5 };
            int[] result = SingleNumber(nums);

            Console.WriteLine("Input: [1,2,1,3,2,5]");
            Console.WriteLine("Single number3 is: " + string.Join(", ", result));
        }
    }
}
