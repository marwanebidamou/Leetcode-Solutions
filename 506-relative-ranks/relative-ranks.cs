public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        for (int i = 0; i < score.Length; i++)
        {
            pq.Enqueue(i, score[i]);
        }

        string[] result = new string[score.Length];

        int counter = 0;
        while (pq.Count > 0)
        {
            var element = pq.Dequeue();
            if (counter == 0)
                result[element] = "Gold Medal";
            else if (counter == 1)
                result[element] = "Silver Medal";
            else if (counter == 2)
                result[element] = "Bronze Medal";
            else
                result[element] = (counter+1).ToString();

            counter++;
        }

        return result;
    }
}