namespace LeetCode.Algorithms.Easy.Arrays;

/// <summary>26. Remove Duplicates from Sorted Array</summary>
/// <remarks>https://leetcode.com/problems/remove-duplicates-from-sorted-array/</remarks>
public sealed class RemoveDuplicatesFromSortedArraySolution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length is 0)
            return 0;

        var uniqueCount = 1;

        for (var numIndex = 1; numIndex < nums.Length; numIndex++)
        {
            if (nums[numIndex] == nums[uniqueCount - 1])
                continue;

            nums[uniqueCount] = nums[numIndex];
            uniqueCount++;
        }

        return uniqueCount;
    }
}
