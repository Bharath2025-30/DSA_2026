//Simplify Path -- Leetcode 71
namespace DSA.Stacks
{
    public class Solution13 {
        public string SimplifyPath(string path) {

            //Approach1: Using Stack
            // string[] files = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            // Console.WriteLine(string.Join(',',files));

            // Stack<string> st = new();
            // StringBuilder str = new();

            // for(int i=0;i<files.Length;i++){
            //     if(files[i] == ".."){
            //         if(st.Count > 0) st.Pop();
            //     }
            //     else if(files[i] != "."){
            //         st.Push(new string(files[i].Reverse().ToArray()));
            //     }
            // }

            // while(st.Count > 0){
            //     str.Append(st.Pop());
            //     str.Append("/");
            // }

            // string res = new string(str.ToString().Reverse().ToArray());
            // return res == "" ? "/" : res;
            

            //Approach2:Linear Traversal Enumeration
            string[] files = path.Split('/',StringSplitOptions.RemoveEmptyEntries);

            var simplifiedFiles = new List<string>();

            for(int i=0;i<files.Length;i++){
                if(files[i] == ".."){
                    if(simplifiedFiles.Count > 0) simplifiedFiles.RemoveAt(simplifiedFiles.Count-1);
                }
                else if(files[i] != "."){
                    simplifiedFiles.Add(files[i]);
                }
            }

            if(simplifiedFiles.Count == 0) return "/";

            return "/" + string.Join("/",simplifiedFiles);
        }
    }
}