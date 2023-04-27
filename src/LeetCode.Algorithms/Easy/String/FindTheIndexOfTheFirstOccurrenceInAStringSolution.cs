namespace LeetCode.Algorithms.Easy.String;

/// <summary>28. Find the Index of the First Occurrence in a String</summary>
/// <remarks>https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/</remarks>
public sealed class FindTheIndexOfTheFirstOccurrenceInAStringSolution
{
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(haystack) ||
            string.IsNullOrEmpty(needle) ||
            haystack.Length < needle.Length)
            return -1;
        
        for (var haystackIndex = 0; haystackIndex < haystack.Length; haystackIndex++)
        {
            var tmpIndex = haystackIndex;
            for (var needleIndex = 0; needleIndex < needle.Length && tmpIndex < haystack.Length ; needleIndex++)
            {
                var needleChar = needle[needleIndex];
                if (haystack[tmpIndex] == needleChar)
                    tmpIndex++;
                else
                    break;
            }

            if (tmpIndex - haystackIndex == needle.Length)
                return haystackIndex;
        }

        return -1;
    }
}
