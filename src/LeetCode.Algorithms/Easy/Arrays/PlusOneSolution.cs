namespace LeetCode.Algorithms.Easy.Arrays;

/// <summary>66. Plus One</summary>
/// <remarks>https://leetcode.com/problems/plus-one/</remarks>
public sealed class PlusOneSolution
{
    public int[] PlusOne(int[] digits)
    {
        var digitsLength = digits.Length;

        var tmpArrayLength = digitsLength + 1;
        var tmpArray = new int[tmpArrayLength];
        
        var inMemory = 1;
        for (var tmpArrayIndex = tmpArrayLength - 1; tmpArrayIndex >= 0; tmpArrayIndex--)
        {
            var digit = 0;
            if (tmpArrayIndex - 1 >= 0)
                digit = digits[tmpArrayIndex - 1];

            var sum = digit + inMemory;
            inMemory = sum / 10;
            
            tmpArray[tmpArrayIndex] = sum % 10;
        }
        
        int resultArrayLength;
        int sourceIndex;
        if (tmpArray.First() is 0)
        {
            resultArrayLength = digitsLength;
            sourceIndex = 1;
        }
        else
        {
            resultArrayLength = tmpArrayLength;
            sourceIndex = 0;
        }

        var resultArray = new int[resultArrayLength];
        Array.Copy(tmpArray, sourceIndex, resultArray, 0, resultArrayLength);
        return resultArray;
    }
}
