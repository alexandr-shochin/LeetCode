﻿namespace LeetCode.Algorithms.Easy;

public sealed class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexByValue = new Dictionary<int, int>();

        for (var numIndex = 0; numIndex < nums.Length; numIndex++)
        {
            var num = nums[numIndex];
            var valueToFind = target - num;

            if (indexByValue.TryGetValue(valueToFind, out var indexToFind))
                return new[] { indexToFind, numIndex };

            indexByValue[num] = numIndex;
        }

        return Array.Empty<int>();
    }
}
