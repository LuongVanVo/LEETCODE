public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');
        if (words.Length != pattern.Length) return false;

        Dictionary<char, string> mapChar = new Dictionary<char, string>();
        Dictionary<string, char> mapString = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            char c = pattern[i];
            string w = words[i];
            if (mapChar.ContainsKey(c))
            {
                if (mapChar[c] != w) return false; 
            } else
            {
                if (mapString.ContainsKey(w)) return false;
            }
            mapChar[c] = w;
            mapString[w] = c;
        }

        return true;
    }
}