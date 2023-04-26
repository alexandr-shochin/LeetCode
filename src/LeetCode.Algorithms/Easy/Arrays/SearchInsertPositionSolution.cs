namespace LeetCode.Algorithms.Easy.Arrays;

/// <summary>35. Search Insert Position</summary>
/// <remarks>https://leetcode.com/problems/search-insert-position/</remarks>
public sealed class SearchInsertPositionSolution
{
    public int SearchInsert(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        
        while (left <= right)
        {
            var middle = (left + right) / 2;
            
            if (target == nums[middle])
                return middle;

            if (target < nums[middle])
                right = middle - 1;
            else
                left = middle + 1;
        }

        return left;
    }
}
