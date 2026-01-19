public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            } else
            {
                map.Add(nums[i], 1);
            }
        }

        // Sort the dictionary by value in descending order
        var sortedMap = map.OrderByDescending(x => x.Value);
        int[] result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = sortedMap.ElementAt(i).Key;
        }
        return result;
    }
}