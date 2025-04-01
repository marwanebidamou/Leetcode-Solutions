public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        List<int> less = new List<int>();
        List<int> equal = new List<int>();
        List<int> greater = new List<int>();

        foreach (var num in nums)
        {
            if (num < pivot)
                less.Add(num);
            else if (num == pivot)
                equal.Add(num);
            else
                greater.Add(num);
        }

        // Concatenate results
        return less.Concat(equal).Concat(greater).ToArray();
    }
}
