public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        int count = 0;

        // sort by end time
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int second = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            int currentFirst = intervals[i][0];
            int currentSecond = intervals[i][1];

            if (currentFirst < second)
            {
                count++;
            } 
            else
            {
                second = currentSecond;
            }
        }
        return count;
    }
}