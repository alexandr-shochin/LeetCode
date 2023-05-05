namespace LeetCode.Algorithms.Easy.Tree;

/// <summary>100. Same Tree</summary>
/// <remarks>https://leetcode.com/problems/same-tree/</remarks>
public sealed class SameTreeSolution
{
    private readonly Queue<TreeNode> _queue = new();
    
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (!IsEqual(p, q))
            return false;
        
        AddNodeToQueue(p?.left);
        AddNodeToQueue(q?.left);
        AddNodeToQueue(p?.right);
        AddNodeToQueue(q?.right);

        while (_queue is not { Count: 0 })
        {
            var currentPNode = _queue.Dequeue();
            var currentQNode = _queue.Dequeue();
            
            if (!IsEqual(currentPNode, currentQNode))
                return false;
            
            AddNodeToQueue(currentPNode.left);
            AddNodeToQueue(currentQNode.left);
            AddNodeToQueue(currentPNode.right);
            AddNodeToQueue(currentQNode.right);
        }

        return true;
    }

    private static bool IsEqual(TreeNode? x, TreeNode? y) =>
        x?.val == y?.val &&
        x?.left?.val == y?.left?.val &&
        x?.right?.val == y?.right?.val;

    private void AddNodeToQueue(TreeNode? node)
    {
        if (node is not null)
            _queue.Enqueue(node);
    }
}
