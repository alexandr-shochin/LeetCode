namespace LeetCode.Algorithms.Easy.LinkedList;

/// <summary>21. Merge Two Sorted Lists</summary>
/// <remarks>https://leetcode.com/problems/merge-two-sorted-lists/</remarks>
public sealed class MergeTwoSortedListsSolution
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var resultRoot = new ListNode();
        var resultTail = resultRoot;

        while (list1 is not null && list2 is not null)
        {
            if (list1.val <= list2.val)
            {
                resultTail.next = list1;
                list1 = list1.next;
            }
            else
            {
                resultTail.next = list2;
                list2 = list2.next;
            }

            resultTail = resultTail.next;
        }

        resultTail.next = list1 ?? list2;

        return resultRoot.next;
    }
}
