namespace LeetCode.Algorithms.Easy.Math;

/// <summary>69. Sqrt(x)</summary>
/// <remarks>https://leetcode.com/problems/sqrtx/</remarks>
public sealed class SqrtXSolution
{
    public int MySqrt(int x)
    {
        if (x is 1)
            return 1;
        
        double leftBorder = 0;
        double rightBorder = x;
        
        var middle = x / 2.0d;
        while (leftBorder <= rightBorder)
        {
            var doubleMiddle = middle * middle;
            if (System.Math.Abs(doubleMiddle - x) < 1e-6)
                return (int)middle;
            
            if (doubleMiddle < x)
                leftBorder = middle;
            else
                rightBorder = middle;
            
            middle = (leftBorder + rightBorder) / 2;
        }

        return (int)middle;
    }
}
