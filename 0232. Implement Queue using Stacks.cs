public class MyQueue {

    Stack<int> myStack = new Stack<int>();
    Stack<int> bufferStack = new Stack<int>();

    /** Initialize your data structure here. */
    public MyQueue() {
            
    }
        
    /** Push element x to the back of queue. */
    public void Push(int x) {
        myStack.Push(x);
    }
        
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        if(bufferStack.Count == 0) {
            TransferToBuffer();
        }

        int top = bufferStack.Peek();
        bufferStack.Pop();
        return top;
    }
        
    /** Get the front element. */
    public int Peek() {
        if(bufferStack.Count == 0) {
            TransferToBuffer();
        }
            
        return bufferStack.Peek();
    }
        
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return myStack.Count == 0 && bufferStack.Count == 0;
    }
    
    private void TransferToBuffer() {
        while(myStack.Count != 0)
        {
            bufferStack.Push(myStack.Peek());
            myStack.Pop();
        }
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