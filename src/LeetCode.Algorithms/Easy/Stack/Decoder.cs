namespace LeetCode.Algorithms.Easy.Stack;

/// <summary>394. Decode String</summary>
/// <remarks>https://leetcode.com/problems/decode-string/</remarks>
public sealed class Decoder
{
    public string Decode(string? inputStr)
    {
        if (string.IsNullOrEmpty(inputStr))
            return string.Empty;

        var stringStack = new Stack<StringBuilder>();
        var countStack = new Stack<int>();

        var currentString = new StringBuilder();
        var repeatCount = 0;

        foreach (var symbol in inputStr)
        {
            if (symbol is >= '0' and <= '9')
            {
                repeatCount = repeatCount * 10 + (symbol - '0');
                continue;
            }

            if (symbol is '[')
            {
                stringStack.Push(currentString);
                countStack.Push(repeatCount);

                currentString = new StringBuilder();
                repeatCount = 0;
                continue;
            }

            if (symbol is ']' && countStack is not { Count: 0 })
            {
                var multiplier = countStack.Pop();

                var multipliedString = new StringBuilder(stringStack.Pop().ToString());
                for (var copyIndex = 0; copyIndex < multiplier; copyIndex++)
                    multipliedString.Append(currentString);

                currentString = multipliedString;
                continue;
            }

            currentString.Append(symbol);
        }

        return currentString.ToString();
    }
}
