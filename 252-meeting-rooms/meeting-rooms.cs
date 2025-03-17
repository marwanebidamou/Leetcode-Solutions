public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        var sorted = intervals.OrderBy(x=>x[0]);

        int lastNumber=-1;
        foreach(var item in sorted)
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