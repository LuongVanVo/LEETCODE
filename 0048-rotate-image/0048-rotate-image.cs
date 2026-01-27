public class Solution {
    public void Rotate(int[][] matrix) {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = i + 1; j < matrix.Length; j++)
            {
                int tmp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = tmp;
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            Array.Reverse(matrix[i]);
        }
    }
}