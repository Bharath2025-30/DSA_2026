namespace DSAProblems.BitManipulation
{
    public class BitManipulationRunner
    {
        public static void Run(int programNo)
        {
            switch (programNo)
            {
                case 1:
                    Console.WriteLine("1: Count set bits");
                    CountSetBits.Solve();
                    break;
                case 2:
                    Console.WriteLine("2. RightMost Set Bit");
                    RightMostSignificantBit.Solve();
                    break;
                case 3:
                    Console.WriteLine("3. N-Gray Code");
                    NGrayCode.Solve();
                    break;
                case 4:
                    Console.WriteLine("4. Minimum number of software developers");
                    MinNoOfSoftwareDevelopers.Solve();
                    break;
                case 5:
                    Console.WriteLine("5. Find Number of valid words from Puzzels");
                    FindNoOfValidWords.Solve();
                    break;
                case 6:
                    Console.WriteLine("6. Single Number 1");
                    SingleNumber1.Solve();
                    break;
                case 8:
                    Console.WriteLine("8. Single Number 3");
                    SingleNumber3.Solve();
                    break;

                default:
                    Console.WriteLine("Invalid program number for BitManipulation");
                    break;
            }
        }
    }
}
