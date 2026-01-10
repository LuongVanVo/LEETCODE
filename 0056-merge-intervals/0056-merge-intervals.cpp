class Solution {
public:
    vector<vector<int>> merge(vector<vector<int>>& intervals) {
        sort(intervals.begin(), intervals.end());
        vector<vector<int>> res;

        int first = intervals[0][0];
        int second = intervals[0][1];

        for (int i = 1; i < intervals.size(); i++) {
            int currFirst = intervals[i][0];
            int currSecond = intervals[i][1];

            if (currFirst <= second) {
                second = max(second, currSecond);
            } else {
                res.push_back({ first, second });
                first = currFirst;
                second = currSecond;
            }
        }
        res.push_back({ first, second });
        return res;
    }
};