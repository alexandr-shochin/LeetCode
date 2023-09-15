namespace LeetCode.Algorithms.Easy.Stack;

/// <summary>20. Valid Parentheses</summary>
/// <remarks>https://leetcode.com/problems/valid-parentheses/</remarks>
public sealed class ValidParenthesesSolution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var ch in s)
        {
            var isOpeningBracket = IsOpeningBracket(ch);
            var isClosingBracket = IsClosingBracket(ch);
            
            if(!(isOpeningBracket || isClosingBracket))
                continue;

            if (isOpeningBracket)
            {
                stack.Push(ch);
                continue;
            }

            if (stack is { Count: 0 })
                return false;

            var peekedChar = stack.Peek();
            switch (ch)
            {
                case ')' when peekedChar is not '(':
                case '}' when peekedChar is not '{':
                case ']' when peekedChar is not '[':
                    return false;
                default:
                    stack.Pop();
                    continue;
            }
        }

        return stack.Count is 0;
    }

    private static bool IsOpeningBracket(char ch) => ch is '(' or '{' or '[';
    private static bool IsClosingBracket(char ch) => ch is ')' or '}' or ']';
}
