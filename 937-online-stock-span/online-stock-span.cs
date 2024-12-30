public class StockSpanner {

    // Stack to store pairs of [price, span]
    // Each element is an array where:
    // - index 0 stores the stock price
    // - index 1 stores the span (number of consecutive days <= current price)
    Stack<int[]> stack = new Stack<int[]>();
    
    public StockSpanner() {

    }
    
    public int Next(int price) {
        // Initialize span as 1 (counting at least the current day)
        int span = 1;
        
        // While the stack is not empty AND
        // the current price is greater than or equal to the price at top of stack
        while(stack.Count > 0 && stack.Peek()[0] <= price) {
            // Add the span of the popped price to our current span
            // This works because if current price >= previous price,
            // it is also >= all the prices included in previous price's span
            span += stack.Pop()[1];
        }

        // Push the current price and its calculated span onto the stack
        stack.Push(new int[] {price, span});
        
        // Return the span for this price
        return span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */