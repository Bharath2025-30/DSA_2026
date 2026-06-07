namespace DSAProblems.BitManipulation
{
    public class FindNoOfValidWords
    {
        public IList<int> FindNumOfValidWords(string[] words, string[] puzzles)
        {

            //Hash the words that are starting with specific char for all 26 char
            Dictionary<char, List<int>> map = new();

            for (int i = 0; i < 26; i++)
            {
                map[(char)(i + 'a')] = new List<int>();
            }

            //calculating wordsMask
            for (int i = 0; i < words.Length; i++)
            {
                int wmask = 0;
                foreach (char ch in words[i])
                {
                    int bit = ch - 'a';
                    wmask = wmask | (1 << bit);
                }

                foreach (char ch in words[i].Distinct())
                {
                    map[ch].Add(wmask);
                }
            }

            List<int> ans = new();

            for (int i = 0; i < puzzles.Length; i++)
            {
                int pmask = 0;
                foreach (char ch in puzzles[i])
                {
                    int bit = ch - 'a';
                    pmask = pmask | (1 << bit);
                }

                char firstChar = puzzles[i][0];
                var wordsToCheck = map[firstChar];
                int cnt = 0;

                foreach (int wmask in wordsToCheck)
                {
                    if ((wmask & pmask) == wmask) cnt++;
                }

                ans.Add(cnt);
            }

            return ans;
        }
        public static void Solve()
        {
            string[] words = { "aaaa", "asas", "able", "ability", "actt", "actor", "access" };
            string[] puzzles = { "aboveyz", "abrodyz", "abslute", "absoryz", "actresz", "gaswxyz" };

            FindNoOfValidWords solver = new FindNoOfValidWords();
            var result = solver.FindNumOfValidWords(words, puzzles);

            Console.WriteLine("Results for sample input:");
            for (int i = 0; i < puzzles.Length; i++)
            {
                Console.WriteLine($"Puzzle: {puzzles[i]}, Valid words count: {result[i]}");
            }
        }
    }
}
