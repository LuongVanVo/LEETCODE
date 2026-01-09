public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int max_freq = 0;
        int max_len = 0;
        int[] count = new int[26];

        for (int right = 0; right < s.Length; right++)
        {
            count[s[right] - 'A']++;
            
            max_freq = Math.Max(max_freq, count[s[right] - 'A']);

            int window_len = right - left + 1;

            if (window_len - max_freq > k)
            {
                count[s[left] - 'A']--;
                left++;
            } 

            max_len = Math.Max(max_len, right - left + 1);
        }
        return max_len;
    }
}