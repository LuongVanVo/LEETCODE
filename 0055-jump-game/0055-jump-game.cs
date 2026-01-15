public class Solution {
    public bool CanJump(int[] nums) {
        if (nums.Length == 1) return true;

        int goal = nums[nums.Length - 1];

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= goal)
            {
                goal = i;
            }
        }
        return goal == 0;
    }
}