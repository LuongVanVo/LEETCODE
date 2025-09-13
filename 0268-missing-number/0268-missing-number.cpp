class Solution {
public:
    int missingNumber(vector<int>& nums) {
        vector<int> arr(nums.size() + 1, -1);
        for (int i = 0; i < nums.size(); i++) {
            arr[nums[i]] = i;
        }
        int res = -1;
        for (int i = 0; i < arr.size(); i++) {
            if (arr[i] == -1) {
                res = i;
            }
        }
        return res;
    }
};