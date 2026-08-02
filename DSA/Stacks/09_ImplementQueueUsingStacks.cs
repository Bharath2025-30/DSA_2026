//Implement Queue using Stacks -- Leetcode 232
namespace DSA.Stacks
{
        public class MyQueue {

        Stack<int> input, output;
        int peekElement;

        public MyQueue() {
            input = new();
            output = new();
            peekElement = -1;
        }
        
        public void Push(int x) {
            if(input.Count == 0) peekElement = x;
            input.Push(x);
        }
        
        public int Pop() {
            if(output.Count > 0) return output.Pop();
            while(input.Count > 0){
                output.Push(input.Pop());
            }
            return output.Pop();
        }
        
        public int Peek() {
            if(output.Count > 0) return output.Peek();
            return peekElement;
        }
        
        public bool Empty() {
            return input.Count == 0 && output.Count == 0;
        }
    }

    /**
    * Your MyQueue object will be instantiated and called as such:
    * MyQueue obj = new MyQueue();
    * obj.Push(x);
    * int param_2 = obj.Pop();
    * int param_3 = obj.Peek();
    * bool param_4 = obj.Empty();
    */
}