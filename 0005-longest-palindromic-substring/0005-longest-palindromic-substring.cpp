class Solution {
public:
    string longestPalindrome(string s) {
        // s = "" + s;
        int start = 0, end = 1;
        int n = s.size();
        if (n == 1) {
            return s;
        }
      int F[1005][1005];
        memset(F, 0, sizeof(F));
        string res = "";
        for (int i = 0; i < n; i++) {
            F[i][i] = true;
        }
        for (int len = 2; len <= n; len++) {
            for (int i = 0; i <= n - len; i++) {
                int j = i + len - 1;
                if (len == 2) {
                    F[i][j] = (s[i] == s[j]);
                } else {
                    F[i][j] = (s[i] == s[j] && F[i + 1][j - 1]);
                }
                if (F[i][j]) {
                    start = i;
                    end = len;
                }
            }
        }
        // return res;
        return s.substr(start, end);
    }
};