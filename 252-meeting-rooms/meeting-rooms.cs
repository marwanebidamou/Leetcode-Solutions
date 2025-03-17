public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        Array.Sort(intervals, (a,b)=>a[0] - b[0]);

        int lastNumber=-1;
        foreach(var item in intervals)
        {
            if(item[0]<lastNumber)
            {
                return false;
            }
            else
            {
                lastNumber = item[1];
            }
        }
        return true;
    }
}