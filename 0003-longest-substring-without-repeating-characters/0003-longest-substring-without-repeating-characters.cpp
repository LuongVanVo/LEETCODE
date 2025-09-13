class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        unordered_set<char> sub;
        int left = 0, right = 0, maxLength = 0;
        while(right < s.size()) {
            if (sub.find(s[right]) == sub.end()) {
                sub.insert(s[right]);
                maxLength = max(maxLength, right - left + 1);
                right++;
            } else {
                sub.erase(s[left]);
                left++;
            }
        }
        return maxLength;
    }
};