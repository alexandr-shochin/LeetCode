namespace LeetCode.Algorithms.Easy;

/// <summary>26. Remove Duplicates from Sorted Array</summary>
/// <remarks>https://leetcode.com/problems/remove-duplicates-from-sorted-array/</remarks>
public sealed class RemoveDuplicatesFromSortedArraySolution
{
    public int RemoveDuplicates(int[] nums)
    {
        var tmpIndex = 1;

        for (var numIndex = 0; numIndex < nums.Length; numIndex++)
        {
            if (nums[numIndex] == nums[tmpIndex - 1])
                continue;

            nums[tmpIndex] = nums[numIndex];
            tmpIndex++;
        }

        return tmpIndex;
    }
}
