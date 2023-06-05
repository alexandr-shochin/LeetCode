namespace LeetCode.Algorithms.Medium.Array;

/// <summary>240. Search a 2D Matrix II</summary>
/// <remarks>https://leetcode.com/problems/search-a-2d-matrix-ii/</remarks>>
public sealed class SearchA2DMatrixIISolution
{
    public bool SearchMatrix(int[][]? matrix, int target)
    {
        if (matrix is null)
            return false;

        var rowLength = matrix.Length;
        var columnLength = matrix[0].Length;

        if (rowLength is 0 || columnLength is 0)
            return false;

        var columnIndex = columnLength - 1;
        var rowIndex = 0;

        while (columnIndex >= 0 && 
               rowIndex < rowLength)
        {
            var value = matrix[rowIndex][columnIndex];
                
            if (value == target)
                return true;
                
            if (value < target)
                rowIndex++;
                
            if (value > target)
                columnIndex--;
        }
        
        return false;
    }
}
