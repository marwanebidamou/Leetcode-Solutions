public class MovingAverage {

    private int _size;
    private int sum = 0;
    private Queue<int> queue = new Queue<int>();
    public MovingAverage(int size) {
        _size = size;
    }
    
    public double Next(int val) {
        while(queue.Count()>=_size)
            sum-=queue.Dequeue();

        sum+=val;
        queue.Enqueue(val);
        return (double)sum/queue.Count();
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */