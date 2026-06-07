namespace DSAProblems.BitManipulation
{
    public class RightMostSignificantBit
    {
        public static void Solve()
        {
            int n = 72;
            string res = Convert.ToString(n & -n, 2).PadLeft(32, '0'); // Rightmost Set Bit Mask
            Console.WriteLine($"Rightmost set bit in {n} is: {res}");
        }
    }
}
