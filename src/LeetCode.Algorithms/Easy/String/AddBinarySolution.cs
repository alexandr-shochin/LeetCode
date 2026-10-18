namespace LeetCode.Algorithms.Easy.String;

/// <summary>67. Add Binary</summary>
/// <remarks>https://leetcode.com/problems/add-binary/</remarks>
public sealed class AddBinarySolution
{
    public string? AddBinary(string? a, string? b)
    {
        if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b))
            return null;

        var resultLength = System.Math.Max(a.Length, b.Length);
        var result = new char[resultLength + 1];

        var carry = '0';
        for (int aIndex = a.Length - 1, bIndex = b.Length - 1, resultIndex = resultLength;
             aIndex >= 0 || bIndex >= 0;
             aIndex--, bIndex--, resultIndex--)
        {
            var (sum, nextCarry) = AddBits(GetValue(a, aIndex), GetValue(b, bIndex), carry);

            result[resultIndex] = sum;
            carry = nextCarry;
        }

        if (carry is '0')
            return new string(result, 1, resultLength);

        result[0] = carry;
        return new string(result);
    }
    
    private static char GetValue(string str, int strIndex) => strIndex >= 0 ? str[strIndex] : '0';

    private static (char sum, char carry) AddBits(char x, char y, char carry)
    {
        var bitsSum = (x - '0') + (y - '0') + (carry - '0');

        return ((char)('0' + (bitsSum % 2)), (char)('0' + (bitsSum / 2)));
    }
}
