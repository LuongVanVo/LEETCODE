public class Solution {
    public long GetDescentPeriods(int[] prices) {
        long totalCount = 0;
        long currentTotal = 1;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] == prices[i - 1] - 1)
            {
                
                currentTotal++;
            } else
            {
                totalCount += demToHop(currentTotal);
                currentTotal = 1;
            }
        }

        totalCount += demToHop(currentTotal);
        return totalCount;
    }

    private long demToHop(long count)
    {
        return (count + 1) * count / 2;
    }
}