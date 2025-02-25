public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);

        int left = 0;
        int right = people.Length-1;
        int boats = 0;

        while(left<=right)
        {
            if(people[left]+people[right]<=limit)
            {
                left++;
                right--;
                boats++;
            }
            else
            {
                right--;
                boats++;
            }            
        }

        return boats;
    }
}