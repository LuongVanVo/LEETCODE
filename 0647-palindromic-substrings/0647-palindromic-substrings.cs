public class Solution {
    public int CountSubstrings(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        int[,] F = new int[s.Length, s.Length];
        // set False for F
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                F[i, j] = 0;
            }
        }
        int ans = 0;
        // base case: single letter is palindrome
        for (int i = 0; i < s.Length; i++)
        {
            F[i, i] = 1;
            ans++;
        }

        for (int len = 2; len <= s.Length; len++)
        {
            for (int i = 0; i <= s.Length - len; i++)
            {
                int j = i + len - 1;
                if (len == 2)
                {
                    F[i, j] = (s[i] == s[j]) ? 1 : 0;
                }
                else
                {
                    F[i, j] = (s[i] == s[j]) && (F[i+1, j - 1] == 1) ? 1 : 0;
                }

                if (F[i, j] == 1)
                {
                    ans++;
                }
            }
        }
    return ans;
    }
}