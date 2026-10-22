namespace LeetCode.Algorithms.Easy.Arrays;

/// <summary>66. Plus One</summary>
/// <remarks>https://leetcode.com/problems/plus-one/</remarks>
public sealed class PlusOneSolution
{
    public int[] PlusOne(int[] digits)
    {
        for (var digitIndex = digits.Length - 1; digitIndex >= 0; digitIndex--)
        {
            if (digits[digitIndex] < 9)
            {
                digits[digitIndex]++;
                return digits;
            }

            digits[digitIndex] = 0;
        }

        var result = new int[digits.Length + 1];
        result[0] = 1;

        return result;
    }
}
