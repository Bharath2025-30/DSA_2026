namespace DSAProblems.BitManipulation
{
    public class NGrayCode
    {
        private static void GetGrayCodes(int n, List<int> res)
        {
            if(n == 0)
            {
                res.Add(0); return;
            }

            GetGrayCodes(n-1,res);
            int mask = 1 << (n-1);

            for(int i = res.Count - 1; i >= 0; i--)
            {
                res.Add(mask | res[i]);
            }
            
        }
        public static void Solve()
        {
            int n = 3;
            Console.WriteLine($"Gray code for {n}:");
            List<int> res = new();
            //Recursive Solution not Optimal
            // GetGrayCodes(n,res); 

            //Optimal Approach
            for(int i=0;i<(1<<n);i++)
            {
                res.Add(i ^ (i>>1));
            }
            Console.WriteLine(string.Join(",", res));
        }
    }
}
