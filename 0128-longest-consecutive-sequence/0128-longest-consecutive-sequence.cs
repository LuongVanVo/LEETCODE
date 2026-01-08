public class Solution {
    public int LongestConsecutive(int[] nums) {
        // new set
        HashSet<int> numSet = new HashSet<int>();
        foreach(int i in nums)
        {
            numSet.Add(i);
        }

        int longest = 0;
        foreach(int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longest = Math.Max(currentStreak, longest);
            }
        }
        return longest;
    }
}