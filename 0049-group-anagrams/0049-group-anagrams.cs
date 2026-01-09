public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);

            string sortedWord = new string(charArray);

            if (!anagrams.ContainsKey(sortedWord))
            {
                anagrams.Add(sortedWord, new List<string>());
            }

            anagrams[sortedWord].Add(str);
        }

        return new List<IList<string>>(anagrams.Values);
        
    }
}