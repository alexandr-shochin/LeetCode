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
            if (ch is '(' or '{' or '[')
                stack.Push(ch);
            else
            {
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
        }

        return stack.Count == 0;
    }
}
