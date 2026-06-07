namespace DSAProblems.BitManipulation
{
    public class CountSetBits
    {
        public static void Solve()
        {
            //Kernighan's Algorithm to count set bits
            int n = 75, count = 0;
            while(n != 0)
            {
                int rsbm = n & -n; // Rightmost Set Bit Mask
                n = n - rsbm; // Remove the rightmost set bit
                count++;
            }
            Console.WriteLine($"Total set bits in {n}: {count}");
        }
    }
}
