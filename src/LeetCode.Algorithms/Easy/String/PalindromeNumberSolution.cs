namespace LeetCode.Algorithms.Easy.String;

/// <summary>9. Palindrome Number</summary>
/// <remarks>https://leetcode.com/problems/palindrome-number/</remarks>>
public sealed class PalindromeNumberSolution
{
    public bool IsPalindrome(int x)
    {
        var chars = x.ToString();
        
        for (var charIndex = 0; charIndex < chars.Length - 1; charIndex++)
            if (chars[charIndex] != chars[chars.Length - 1 - charIndex])
                return false;

        return true;
    }
}
