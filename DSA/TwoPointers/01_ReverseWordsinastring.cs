// Reverse Words in a string - Leetcode 151
namespace DSA.TwoPointers
{
    public class Solution1 {
        private static void Reverse(char[] str, int s, int e){
            while(s < e){
                (str[s], str[e]) = (str[e], str[s]);
                s++; e--;
            }
        }
        public string ReverseWords(string s) {
            // char[] str = s.ToCharArray();
            // int n = str.Length;

            // //Reverse whole str
            // Reverse(str, 0, n-1);

            // //Reverse individual word
            // int i=0, l = 0, r = 0;
            // while(i < n){
            //     while(i<n && str[i] != ' '){
            //         str[r] = str[i];
            //         i++;r++;
            //     }

            //     if(l < r){
            //         Reverse(str,l,r-1);
            //         if(r < n) str[r] = ' ';
            //         r++;
            //         l = r;
            //     }
                
            //     i++;
            // }

            // return new string(str).Substring(0,r-1);

            //Approach2:
            string[] words = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ",words);
        }
    }
}