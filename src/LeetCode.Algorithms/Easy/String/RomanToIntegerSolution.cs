namespace LeetCode.Algorithms.Easy.String;

/// <summary>13. Roman to Integer</summary>
/// <remarks>https://leetcode.com/problems/roman-to-integer/</remarks>
public sealed class RomanToIntegerSolution
{
    public int RomanToInt(string s)
    {
        var result = 0;

        for (var symbolIndex = 0; symbolIndex < s.Length; symbolIndex++)
        {
            var value = GetValue(s[symbolIndex]);

            if (symbolIndex + 1 < s.Length && value < GetValue(s[symbolIndex + 1]))
                result -= value;
            else
                result += value;
        }

        return result;
    }

    private static int GetValue(char symbol) => symbol switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => 0,
    };
}
