public class MyStack {

    Queue<int> myQueue = new Queue<int>();
        /** Initialize your data structure here. */
        public MyStack() {
            
        }
        
        /** Push element x onto stack. */
        public void Push(int x) {
            myQueue.Enqueue(x);
            int size = myQueue.Count;
            for(int i = 0 ; i < size -1;++i)
            {
                myQueue.Enqueue(Pop());
            }
        }
        
        /** Removes the element on top of the stack and returns that element. */
        public int Pop() {
            return myQueue.Dequeue();
        }
        
        /** Get the top element. */
        public int Top() {
            return myQueue.Peek();
        }
        
        /** Returns whether the stack is empty. */
        public bool Empty() {
            return myQueue.Count == 0;
        }
    
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */