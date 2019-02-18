public class Solution {
    public bool IsToeplitzMatrix(int[,] matrix) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        for (int i=0; i<m; i++)
        {
            for(int j=0; j < n; j++)
            {
                if (i + 1 >= m || j + 1 >= n) continue;
                else
                {
                    var cur = matrix[i, j];
                    var diagonal_next = matrix[i + 1, j + 1];
                    if (cur != diagonal_next)
                        return false;
                }
            }
        }
        return true;
    }
}