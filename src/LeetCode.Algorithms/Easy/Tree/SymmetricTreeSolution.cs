namespace LeetCode.Algorithms.Easy.Tree;

/// <summary>101. Symmetric Tree</summary>
/// <remarks>https://leetcode.com/problems/symmetric-tree/</remarks>
public sealed class SymmetricTreeSolution
{
    public bool IsSymmetric(TreeNode? root)
    {
        if (root is null)
            return true;

        var pairs = new Queue<(TreeNode? left, TreeNode? right)>();
        pairs.Enqueue((root.left, root.right));

        while (pairs is not { Count: 0 })
        {
            var (left, right) = pairs.Dequeue();

            if (left is null && right is null)
                continue;

            if (left is null || right is null || left.val != right.val)
                return false;

            pairs.Enqueue((left.left, right.right));
            pairs.Enqueue((left.right, right.left));
        }

        return true;
    }
}
