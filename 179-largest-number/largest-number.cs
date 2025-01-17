public class Solution
{
    public string LargestNumber(int[] nums)
    {
        // Convert each integer to a string
        string[] numStrings = nums.Select(num => num.ToString()).ToArray();

        // Sort strings based on concatenated values
        Array.Sort(numStrings, (a, b) => string.Compare(b + a, a + b, StringComparison.Ordinal));

        // Handle the case where the largest number is zero
        if (numStrings[0] == "0")
        {
            return "0";
        }

        // Concatenate sorted strings to form the largest number
        StringBuilder largestNum = new StringBuilder();
        foreach (var numStr in numStrings)
        {
            largestNum.Append(numStr);
        }

        return largestNum.ToString();
    }
}
