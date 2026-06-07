namespace DSAProblems.BitManipulation
{
    public class SingleNumber1
    {
        public int SingleNumber(int[] nums) {
            int xor = 0;
            foreach(int num in nums){
                xor ^= num;
            }

            return xor;
        }
        public static void Solve()
        {
            int[] nums = { 4, 1, 2, 1, 2 };
            SingleNumber1 solver = new SingleNumber1();
            int result = solver.SingleNumber(nums);

            Console.WriteLine("Input: [4,1,2,1,2]");
            Console.WriteLine("Single number is: " + result);
        }
    }
}
