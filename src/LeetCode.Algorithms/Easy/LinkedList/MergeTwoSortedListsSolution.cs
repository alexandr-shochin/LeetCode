namespace LeetCode.Algorithms.Easy.LinkedList;

/// <summary>21. Merge Two Sorted Lists</summary>
/// <remarks>https://leetcode.com/problems/merge-two-sorted-lists/</remarks>
public sealed class MergeTwoSortedListsSolution
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var resultHead = new ListNode();

        ListNode? tmpListNode;
        for (tmpListNode = resultHead;
             list1 is not null && list2 is not null;
             tmpListNode = tmpListNode.next)
        {
            if (list1.val <= list2.val)
            {
                tmpListNode.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                tmpListNode.next = new ListNode(list2.val);
                list2 = list2.next;
            }
        }

        for (var residualList = list1 ?? list2;
             residualList is not null;
             residualList = residualList.next, tmpListNode = tmpListNode.next)
            tmpListNode.next = new ListNode(residualList.val);

        return resultHead.next;
    }
}
