namespace LeetCode.Algorithms.Easy.Tree;

/// <summary>111. Minimum Depth of Binary Tree</summary>
/// <remarks>https://leetcode.com/problems/minimum-depth-of-binary-tree/</remarks>>
public sealed class MinimumDepthOfBinaryTreeSolution
{
    public int MinDepth(TreeNode? root)
    {
        if (root is null)
            return 0;

        var queue = new Queue<(TreeNode node, int depth)>();
        queue.Enqueue((root, 1));

        while (queue is not { Count: 0 })
        {
            var (currentNode, depth) = queue.Dequeue();

            if (currentNode.left is null && currentNode.right is null)
                return depth;

            if (currentNode.left is not null)
                queue.Enqueue((currentNode.left, depth + 1));

            if (currentNode.right is not null)
                queue.Enqueue((currentNode.right, depth + 1));
        }

        return 0;
    }
}
