public class MinStack {
    // Idea is to keep a normal stack and another stack to track the minimum of the whole stack at that location
    // Stack : 5, 4, 7 ,8 , -2 
    //MinStac: 5 ,4, 4, 4, -2
    private Stack<int> myStack;
    private Stack<int> minStack;
    public MinStack() {
        myStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        myStack.Push(val);
        // If the minstack is empty we just add this value
        if(minStack.Count == 0){
            minStack.Push(val);
        }
        // If not we compare it to the current number
        else{
            if(val < minStack.Peek()){
                minStack.Push(val);
            }
            else{
                minStack.Push(minStack.Peek());
            }
        }
    }
    
    public void Pop() {
        myStack.Pop();
        minStack.Pop(); 
    }
    
    public int Top() {
        return myStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}


/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */