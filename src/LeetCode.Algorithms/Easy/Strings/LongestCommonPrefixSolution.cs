namespace LeetCode.Algorithms.Easy.Strings;

/// <summary>14. Longest Common Prefix</summary>
/// <remarks>https://leetcode.com/problems/longest-common-prefix/</remarks>>
public sealed class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var stringsLength = strs.Length;
        
        if (stringsLength == 0)
            return string.Empty;

        var result = new StringBuilder();

        var firstStr = strs.First();
        
        if (stringsLength == 1)
            return firstStr;
        
        var shortestStringLength = strs.Min(str => str.Length);
        
        if (shortestStringLength == 0)
            return result.ToString();
        
        var isEqual = true;
        for (var indexShortestString = 0; indexShortestString < shortestStringLength; indexShortestString++)
        {
            for (var indexString = 0; indexString < stringsLength - 1; indexString++)
            {
                if (strs[indexString][indexShortestString] == strs[indexString + 1][indexShortestString])
                    continue;
                
                isEqual = false;
                break;
            }

            if (!isEqual)
                return result.ToString();

            result.Append(firstStr[indexShortestString]);
        }

        return result.ToString();
    }
}
