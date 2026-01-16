public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        // TH1: Cướp nhà đầu bỏ nhà cuối
        int max1 = RobPartition(nums, 0, nums.Length - 2);

        // TH2: Cướp nhà cuối bỏ nhà đầu
        int max2 = RobPartition(nums, 1, nums.Length - 1);

        return Math.Max(max1, max2);
    }

    private int RobPartition(int[] nums, int start, int end)
    {
        if (start == end) return nums[start];

        int [] F = new int[nums.Length];

        F[start] = nums[start];
        F[start + 1] = Math.Max(nums[start], nums[start + 1]);

        for (int i = start + 2; i <= end; i++)
        {
            F[i] = Math.Max(F[i - 1], nums[i] + F[i - 2]);
        }

        return F[end];
    }
}