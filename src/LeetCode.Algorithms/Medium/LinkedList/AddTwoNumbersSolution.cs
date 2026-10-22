namespace LeetCode.Algorithms.Medium.LinkedList;

/// <summary>2. Add Two Numbers</summary>
/// <remarks>https://leetcode.com/problems/add-two-numbers/</remarks>
public sealed class AddTwoNumbersSolution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        if (l1 is null && l2 is null)
            throw new ArgumentException("At least one of the lists must be non-empty.");

        var resultRoot = new ListNode();
        var resultTail = resultRoot;

        var inMemory = 0;
        while (l1 is not null || l2 is not null || inMemory != 0)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + inMemory;
            inMemory = sum / 10;

            resultTail.next = new ListNode(sum % 10);
            resultTail = resultTail.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return resultRoot.next!;
    }
}
