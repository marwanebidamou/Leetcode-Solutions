public class Solution
{
    public int MinArraySum(int[] nums, int k, int op1, int op2)
    {
        int n = nums.Length;
        // Initialize memoization array with -1
        int[,,] memo = new int[n, op1 + 1, op2 + 1];
        for (int i = 0; i < n; i++)
            for (int j = 0; j <= op1; j++)
                for (int l = 0; l <= op2; l++)
                    memo[i, j, l] = -1;

        return MinArraySumFunc(nums, k, op1, op2, 0, memo); // Start recursive calculation from the first index
    }

    // Recursive helper function to calculate the minimum array sum
    public int MinArraySumFunc(int[] nums, int k, int op1, int op2, int index, int[,,] memo)
    {
        // Base case: If we reach the end of the array, return 0 (no more elements to process)
        if (index == nums.Length)
            return 0;

        // Check if the result for this state is already computed
        if (memo[index, op1, op2] != -1)
            return memo[index, op1, op2];


        int answer = int.MaxValue; // Initialize the answer with the maximum possible integer value

        // Apply operation 1: Halve the current element if op1 > 0
        if (op1 > 0)
        {
            int sumOp1 = ((int)Math.Ceiling(nums[index] / 2.00)) // Halve the current element
                         + MinArraySumFunc(nums, k, op1 - 1, op2, index + 1, memo); // Recur for the next element
            answer = Math.Min(answer, sumOp1); // Update the answer with the minimum value
        }

        // Apply operation 2: Subtract k from the current element if op2 > 0 and nums[index] >= k
        if (op2 > 0 && nums[index] >= k)
        {
            int sumOp2 = (nums[index] - k) // Subtract k from the current element
                         + MinArraySumFunc(nums, k, op1, op2 - 1, index + 1, memo); // Recur for the next element
            answer = Math.Min(answer, sumOp2); // Update the answer with the minimum value
        }

        // Apply both operations sequentially if op1 > 0 and op2 > 0
        if (op1 > 0 && op2 > 0)
        {
            int afterOp1 = (int)Math.Ceiling(nums[index] / 2.00); // Halve the current element
            if (afterOp1 >= k) // Check if the halved value is still >= k for operation 2
            {
                int sumOp1Op2 = (afterOp1 - k) // Apply operation 2 on the halved value
                                + MinArraySumFunc(nums, k, op1 - 1, op2 - 1, index + 1, memo); // Recur for the next element
                answer = Math.Min(answer, sumOp1Op2); // Update the answer with the minimum value
            }
        }

        // Apply both operations sequentially if op1 > 0 and op2 > 0 in reverse order (op2 first, then op1)
        if (op1 > 0 && op2 > 0)
        {
            if(nums[index] >= k)
            {
                int sumAfterOp2 = nums[index] - k;
                //Apply operation 1
                int sumAfterOp1 =  (int)Math.Ceiling(sumAfterOp2 / 2.00);

                int finalSum = sumAfterOp1
                                 + MinArraySumFunc(nums, k, op1 - 1, op2 - 1, index + 1, memo); // Recur for the next element
                
                answer = Math.Min(answer, finalSum);
            }            
        }

        // Case: Perform no operation and include the current element as-is
        int noOperation = nums[index] + MinArraySumFunc(nums, k, op1, op2, index + 1, memo);

        // Update the answer with the minimum of all possible cases
        answer = Math.Min(answer, noOperation);

        // Store the result in the cache
        memo[index, op1, op2] = answer;

        return answer; // Return the final minimum value
    }
}
