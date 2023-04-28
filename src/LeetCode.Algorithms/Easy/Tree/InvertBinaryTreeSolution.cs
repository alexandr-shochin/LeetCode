namespace LeetCode.Algorithms.Easy.Tree;

/// <summary>226. Invert Binary Tree</summary>
/// <remarks>https://leetcode.com/problems/invert-binary-tree/</remarks>
public sealed class InvertBinaryTreeSolution
{
    public TreeNode? InvertTree(TreeNode? root)
    {
        if (root is null)
            return null;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue is not { Count: 0 })
        {
            var currentNode = queue.Dequeue();

            (currentNode.left, currentNode.right) = (currentNode.right, currentNode.left); // swap
            
            if(currentNode.right is not null)
                queue.Enqueue(currentNode.right);
            
            if(currentNode.left is not null)
                queue.Enqueue(currentNode.left);
        }

        return root;
    }
}
