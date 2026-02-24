public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        // dùng set để lưu lại các hàng và cột cần set về 0
        HashSet<int> rows = new HashSet<int>();
        HashSet<int> cols = new HashSet<int>();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }

        // set về 0 các hàng đã lưu
        foreach (int row in rows)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[row][j] = 0;
            }
        }

        foreach(int col in cols)        {
            for (int i = 0; i < m; i++)
            {
                matrix[i][col] = 0;
            }
        }
    }
}