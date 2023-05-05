namespace LeetCode.Algorithms.Easy.Tree;

/// <summary>111. Minimum Depth of Binary Tree</summary>
/// <remarks>https://leetcode.com/problems/minimum-depth-of-binary-tree/</remarks>>
public sealed class MinimumDepthOfBinaryTreeSolution
{
    private readonly Queue<(TreeNode, int)> _queue = new();
    private int _minDepth = int.MaxValue;
    
    public int MinDepth(TreeNode? root)
    {
        if (root is null)
            return 0;

        if (root.left is null && root.right is null)
            return 1;

        AddAdjacentNodes(root, 1);

        while (_queue is not { Count: 0 })
        {
            var (currentNode, depth) = _queue.Dequeue();

            if (IsLeaf(currentNode))
            {
                _minDepth = depth;
                break;
            }

            AddAdjacentNodes(currentNode, depth);
        }

        return _minDepth;
    }

    private void AddAdjacentNodes(TreeNode node, int depth)
    {
        AddNodeToQueue(node.left, depth);
        AddNodeToQueue(node.right, depth);
    }

    private void AddNodeToQueue(TreeNode? node, int prevDepth)
    {
        if (node is null)
            return;
        
        _queue.Enqueue((node, prevDepth + 1));
    }

    private bool IsLeaf(TreeNode node) => node.left is null && node.right is null;
}
