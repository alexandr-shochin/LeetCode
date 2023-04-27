namespace LeetCode.Algorithms.Easy.LinkedList;

/// <summary>83. Remove Duplicates from Sorted List</summary>
/// <remarks>https://leetcode.com/problems/remove-duplicates-from-sorted-list</remarks>
public sealed class RemoveDuplicatesFromSortedListSolution
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        if (head is null)
            return null;
        
        if(head.next is null)
            return head;
        
        var resultRootNode = new ListNode(head.val);

        var tmpNode = resultRootNode;
        var prevNode = tmpNode;
        for (var currentNode = head.next; currentNode is not null; currentNode = currentNode.next)
        {
            if (prevNode.val != currentNode.val)
            {
                tmpNode.next = new ListNode(currentNode.val);
                tmpNode = tmpNode.next;
            }

            prevNode = currentNode;
        }

        return resultRootNode;
    }
}
