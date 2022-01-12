public class MyQueue {
    public Stack<int> stack1;
    public Stack<int> stack2;
    public MyQueue() {
        this.stack1 = new Stack<int>();
        this.stack2 = new Stack<int>();
    }
    
    public void Push(int x) {
        this.stack1.Push(x);
    }
    
    public int Pop() {
        if(this.stack2.Count == 0){
            while(this.stack1.Count != 0){
                this.stack2.Push(this.stack1.Pop());
            }
        }
        return this.stack2.Pop();
    }
    
    public int Peek() {
        if(this.stack2.Count == 0){
            while(this.stack1.Count != 0){
                this.stack2.Push(this.stack1.Pop());
            }
        }
        return this.stack2.Peek();
    }
    
    public bool Empty() {
        return this.stack1.Count == 0 && this.stack2.Count == 0; 
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
