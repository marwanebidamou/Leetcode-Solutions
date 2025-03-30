public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> result = new List<IList<int>>();

        backtrack(1,new List<int>());

        void backtrack(int start, List<int> list)
        {
            if(list.Count == k)
            {
                result.Add(new List<int>(list)); 
                return;
            }
            for(int i=start;i<=n;i++)
            {
                if(!list.Contains(i))
                {
                    list.Add(i);
                    backtrack(i+1,list);
                    list.RemoveAt(list.Count - 1);

                }
                
            }
        }

        return result;


    }
}