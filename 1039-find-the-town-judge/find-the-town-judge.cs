public class Solution {
    public int FindJudge(int n, int[][] trust) {

        int[] people = new int[n];
        HashSet<int> trustSomeone = new HashSet<int>();
        
        for(int i=0;i<trust.Length;i++)
        {            
            people[trust[i][1]-1]++;
            trustSomeone.Add(trust[i][0]-1);
        }

        for(int i=0;i<n;i++)
        {
            if(people[i]==n-1 && !trustSomeone.Contains(i))
            {
                return i+1;
            }
        }
        return -1;
    }
}