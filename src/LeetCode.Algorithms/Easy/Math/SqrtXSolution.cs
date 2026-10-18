namespace LeetCode.Algorithms.Easy.Math;

/// <summary>69. Sqrt(x)</summary>
/// <remarks>https://leetcode.com/problems/sqrtx/</remarks>
public sealed class SqrtXSolution
{
    public int MySqrt(int input)
    {
        var leftBorder = 0;
        var rightBorder = input;

        while (leftBorder <= rightBorder)
        {
            var middle = leftBorder + ((rightBorder - leftBorder) / 2);
            var square = (long)middle * middle;

            if (square == input)
                return middle;

            if (square < input)
                leftBorder = middle + 1;
            else
                rightBorder = middle - 1;
        }

        return rightBorder;
    }
}
