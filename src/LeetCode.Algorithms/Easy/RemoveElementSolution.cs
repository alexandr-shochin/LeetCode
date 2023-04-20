namespace LeetCode.Algorithms.Easy;

/// <summary>27. Remove Element</summary>
/// <remarks>https://leetcode.com/problems/remove-element/</remarks>
public sealed class RemoveElementSolution
{
    public int RemoveElement(int[] nums, int val)
    {
        var tmpIndex = 0;
        
        for (var numIndex = 0; numIndex < nums.Length; numIndex++)
        {
            if (nums[numIndex] == val)
                continue;
            
            nums[tmpIndex] = nums[numIndex];
            tmpIndex++;
        }

        return tmpIndex;
    }
}
