namespace LeetCode.Algorithms.Easy.String;

/// <summary>67. Add Binary</summary>
/// <remarks>https://leetcode.com/problems/add-binary/</remarks>
public sealed class AddBinarySolution
{
    public string? AddBinary(string? a, string? b)
    {
        if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b))
            return null;

        var result = string.Empty;
        
        var (sum, inMemory) = ('0', '0');
        for (int aIndex = a.Length - 1, bIndex = b.Length - 1;
             aIndex >= 0 || bIndex >= 0;
             aIndex--, bIndex--)
        {
            var aValue = GetValue(a, aIndex);
            var bValue = GetValue(b, bIndex);

            (sum, inMemory) = AddBits(aValue, bValue, inMemory);
            result = string.Concat(sum, result);
        }
        
        if(inMemory is not '0')
            result = string.Concat(inMemory, result);
        
        return result;
    }

    private char GetValue(string str, int strIndex) =>
        strIndex < str.Length && strIndex >= 0
            ? str[strIndex]
            : '0';

    private (char sum, char inMemory) AddBits(char x, char y, char inMemory)
    {
        if (x is '0' && y is '0')
        {
            switch (inMemory)
            {
                case '0':
                    return (sum:'0', inMemory:'0');
                case '1':
                    return (sum:'1', inMemory:'0');
            }
        }
        
        if ((x is '0' && y is '1') || (x is '1' && y is '0'))
        {
            switch (inMemory)
            {
                case '0':
                    return (sum:'1', inMemory:'0');
                case '1':
                    return (sum:'0', inMemory:'1');
            }
        }
        
        if (x is '1' && y is '1')
        {
            switch (inMemory)
            {
                case '0':
                    return (sum:'0', inMemory:'1');
                case '1':
                    return (sum:'1', inMemory:'1');
            }
        }

        return (sum:'0', inMemory:'0');
    }
}
