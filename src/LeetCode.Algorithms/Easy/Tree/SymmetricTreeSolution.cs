namespace LeetCode.Algorithms.Easy.Tree;

/// <summary>101. Symmetric Tree</summary>
/// <remarks>https://leetcode.com/problems/symmetric-tree/</remarks>
public sealed class SymmetricTreeSolution
{
    public bool IsSymmetric(TreeNode? root)
    {
        if (root is null)
            return false;
        
        if(root.left?.val != root.right?.val)
            return false;
        
        var leftSubTreeQueue = new Queue<TreeNode?>();
        if (root.left is not null)
            leftSubTreeQueue.Enqueue(root.left);
            
        var rightSubTreeQueue = new Queue<TreeNode?>();
        if (root.right is not null)
            rightSubTreeQueue.Enqueue(root.right);
        
        while (leftSubTreeQueue is not { Count: 0 } ||
               rightSubTreeQueue is not { Count: 0 })
        {
            var currentSubLeftNode = leftSubTreeQueue.Dequeue();
            var currentSubRightNode = rightSubTreeQueue.Dequeue();

            if(currentSubLeftNode!.left?.val != currentSubRightNode!.right?.val ||
               currentSubLeftNode.right?.val != currentSubRightNode.left?.val)
                return false;

            if (currentSubLeftNode.left is not null)
                leftSubTreeQueue.Enqueue(currentSubLeftNode.left);
            if (currentSubLeftNode.right is not null)
                leftSubTreeQueue.Enqueue(currentSubLeftNode.right);
            
            if (currentSubRightNode.right is not null)
                rightSubTreeQueue.Enqueue(currentSubRightNode.right);
            if (currentSubRightNode.left is not null)
                rightSubTreeQueue.Enqueue(currentSubRightNode.left);
        }

        return true;
    }
}
