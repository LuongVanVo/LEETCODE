public class Solution {
    public int FindJudge(int n, int[][] trust) {
        if (n == 1 && trust.Length == 0) return 1;
        int[] scores = new int[n + 1];

        foreach (var i in trust)
        {
            int resident = i[0];
            int trusted = i[1];

            scores[resident]--;

            scores[trusted]++;
        }

        // check for judge
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] == n - 1)
            {
                return i;
            }
        }
        return -1;
    }
}