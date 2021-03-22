public class MyQueue
{
    public Stack<int> S1 { get; set; }
    public Stack<int> S2 { get; set; }

    /** Initialize your data structure here. */
    public MyQueue()
    {
        S1 = new Stack<int>();
        S2 = new Stack<int>();
    }

    /** Push element x to the back of queue. */
    public void Push(int x)
    {
        S2.Push(x);
        return;
    }

    /** Removes the element from in front of queue and returns that element. */
    public int Pop()
    {
        this.Transfer();
        int ret = S1.Peek();
        S1.Pop();
        return ret;
    }

    /** Get the front element. */
    public int Peek()
    {
        this.Transfer();
        return S1.Peek();
    }

    /** Returns whether the queue is empty. */
    public bool Empty()
    {
        return S1.Count == 0 && S2.Count == 0;
    }

    public void Transfer()
    {
        if (S1.Count > 0) return;
        while (S2.Count > 0)
        {
            S1.Push(S2.Peek());
            S2.Pop();
        }
        return;
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