public class Solution {


    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();

        backtrack(new List<int>{});
        

        void backtrack(List<int> list)
        {
            if(list.Count == nums.Length)
            {
                result.Add(new List<int>(list));
                return;
            }

            for(int i=0;i<nums.Length;i++)
            {
                if(!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                    backtrack(list);
                    list.RemoveAt(list.Count-1);
                }              
            }
        }


        return result;
    }



}