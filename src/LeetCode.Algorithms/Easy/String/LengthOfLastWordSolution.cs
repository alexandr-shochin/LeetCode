namespace LeetCode.Algorithms.Easy.String;

/// <summary>58. Length of Last Word</summary>
/// <remarks>https://leetcode.com/problems/length-of-last-word/</remarks>
public sealed class LengthOfLastWordSolution
{
    public int LengthOfLastWord(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;
        
        var length = 0;
        var isFind = false;
        for (var sIndex = s.Length - 1; sIndex >= 0 ; sIndex--)
        {
            if (char.IsWhiteSpace(s[sIndex]))
            {
                if (isFind)
                    return length;
                
                length = 0;
                continue;
            }

            length++;
            isFind = true;
        }

        return length;
    }
}
