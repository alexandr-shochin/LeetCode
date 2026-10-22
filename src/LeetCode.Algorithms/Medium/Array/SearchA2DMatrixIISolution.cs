namespace LeetCode.Algorithms.Medium.Array;

/// <summary>240. Search a 2D Matrix II</summary>
/// <remarks>https://leetcode.com/problems/search-a-2d-matrix-ii/</remarks>
public sealed class SearchA2DMatrixIISolution
{
    public bool SearchMatrix(int[][]? matrix, int target)
    {
        if (matrix is null || matrix.Length is 0)
            return false;

        var rowLength = matrix.Length;
        var columnLength = matrix[0].Length;

        if (columnLength is 0)
            return false;

        var rowIndex = 0;
        var columnIndex = columnLength - 1;

        while (rowIndex < rowLength && columnIndex >= 0)
        {
            var value = matrix[rowIndex][columnIndex];

            if (value == target)
                return true;

            if (value < target)
                rowIndex++;
            else
                columnIndex--;
        }

        return false;
    }
}
