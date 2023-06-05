namespace LeetCode.Algorithms.Easy.String;

/// <summary>125. Valid Palindrome</summary>
/// <remarks>https://leetcode.com/problems/valid-palindrome/</remarks>>
public sealed class ValidPalindromeSolution
{
    public bool IsPalindrome(string s)
    {
        var targetCharsIndex = 0;
        var chars = s.ToCharArray();

        var isNotEmpty = false;
        for (var charIndex = 0; charIndex < chars.Length; charIndex++)
        {
            var ch = s[charIndex];
            if (!IsAlphanumeric(ch))
                continue;
            
            chars[targetCharsIndex++] = char.ToLower(ch);
            isNotEmpty = true;
        }

        if (!isNotEmpty)
            return true;
        
        for (var charIndex = 0; charIndex < targetCharsIndex - 1; charIndex++)
            if (chars[charIndex] != chars[targetCharsIndex - 1 - charIndex])
                return false;

        return true;
    }

    private static bool IsAlphanumeric(char ch) =>
        char.IsDigit(ch) ||
        char.IsLetter(ch);
}
