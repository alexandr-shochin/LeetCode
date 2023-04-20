namespace LeetCode.Algorithms.Easy.Tree;

public class TreeNode
{
    public int Val { get; }
    public TreeNode? Left { get; }
    public TreeNode? Right { get; }

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        Val = val;
        Left = left;
        Right = right;
    }
}

/// <summary>104. Maximum Depth of Binary Tree</summary>
/// <remarks>https://leetcode.com/problems/maximum-depth-of-binary-tree/</remarks>
public sealed class MaximumDepthOfBinaryTreeSolution
{
    private Stack<(TreeNode node, int depth)> _stack = null!;
    private int _maxDepth;
    
    public int MaxDepth(TreeNode? root)
    {
        if (root is null)
            return 0;
        
        _stack = new Stack<(TreeNode node, int depth)>();
        _maxDepth = 1;
        
        AddAdjacentNodes((root, 1));

        while (_stack is not { Count: 0 })
            AddAdjacentNodes(_stack.Pop());

        return _maxDepth;
    }

    private void AddAdjacentNodes((TreeNode node, int depth) currentNode)
    {
        AddNodeToStack(currentNode.node.Left, currentNode.depth);
        AddNodeToStack(currentNode.node.Right, currentNode.depth);
    }

    private void AddNodeToStack(TreeNode? node, int prevDepth)
    {
        if (node is null)
            return;
        
        var newDepth = prevDepth + 1;
        _stack.Push((node, newDepth));
        _maxDepth = _maxDepth < newDepth ? newDepth : _maxDepth;
    }
}
