namespace LeetCode.Algorithms.Medium.Stack;

/// <summary>394. Decode String</summary>
/// <remarks>https://leetcode.com/problems/decode-string/</remarks>
public sealed class DecodeStringSolution
{
    public string DecodeString(string s)
    {
        ArgumentNullException.ThrowIfNull(s);

        var prefixes = new Stack<(StringBuilder Builder, int RepeatCount)>();
        var currentString = new StringBuilder();
        var repeatCount = 0;

        foreach (var symbol in s)
        {
            if (char.IsAsciiDigit(symbol))
            {
                repeatCount = repeatCount * 10 + (symbol - '0');
                continue;
            }

            switch (symbol)
            {
                case '[':
                    prefixes.Push((currentString, repeatCount));
                    currentString = new StringBuilder();
                    repeatCount = 0;
                    break;

                case ']' when prefixes is not { Count: 0 }:
                    var (prefix, count) = prefixes.Pop();
                    for (var copyIndex = 0; copyIndex < count; copyIndex++)
                        prefix.Append(currentString);

                    currentString = prefix;
                    break;

                default:
                    currentString.Append(symbol);
                    break;
            }
        }

        return currentString.ToString();
    }
}
