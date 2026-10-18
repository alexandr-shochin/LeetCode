namespace LeetCode.Algorithms.Easy.Tree;

/// <summary>104. Maximum Depth of Binary Tree</summary>
/// <remarks>https://leetcode.com/problems/maximum-depth-of-binary-tree/</remarks>
public sealed class MaximumDepthOfBinaryTreeSolution
{
    public int MaxDepth(TreeNode? root)
    {
        if (root is null)
            return 0;

        var maxDepth = 0;
        var stack = new Stack<(TreeNode node, int depth)>();
        stack.Push((root, 1));

        while (stack is not { Count: 0 })
        {
            var (currentNode, depth) = stack.Pop();
            maxDepth = maxDepth < depth ? depth : maxDepth;

            if (currentNode.left is not null)
                stack.Push((currentNode.left, depth + 1));

            if (currentNode.right is not null)
                stack.Push((currentNode.right, depth + 1));
        }

        return maxDepth;
    }
}
