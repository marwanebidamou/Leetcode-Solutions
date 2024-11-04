public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> list = new List<IList<int>>();

        list.Add(new List<int>() { 1 });

        if (numRows == 1)
            return list;

        for (int i = 1; i < numRows; i++)
        {
            list.Add(new int[i+1]);
            int columnIndex = 0;
            list[i][columnIndex++] = list[i - 1][0];

            int j = 0;
            while (j < list[i - 1].Count - 1)
            {
                list[i][columnIndex++] = list[i - 1][j] + (j >= list[i - 1].Count ? 0 : list[i - 1][j + 1]);
                j++;
            }
            list[i][columnIndex++] = list[i - 1][^1];

            columnIndex = 0;
        }

        return list;
    }
}