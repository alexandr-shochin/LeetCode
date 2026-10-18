namespace LeetCode.Algorithms.Easy.Tree;

/// <summary>100. Same Tree</summary>
/// <remarks>https://leetcode.com/problems/same-tree/</remarks>
public sealed class SameTreeSolution
{
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        var queue = new Queue<(TreeNode? first, TreeNode? second)>();
        queue.Enqueue((p, q));

        while (queue is not { Count: 0 })
        {
            var (first, second) = queue.Dequeue();

            if (first is null && second is null)
                continue;

            if (first is null || second is null || first.val != second.val)
                return false;

            queue.Enqueue((first.left, second.left));
            queue.Enqueue((first.right, second.right));
        }

        return true;
    }
}
