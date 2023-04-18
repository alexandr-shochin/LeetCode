namespace LeetCode.Algorithms.Medium;

public class ListNode 
{
    public int val;
    public ListNode? next;
    
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

/// <summary> 2. Add Two Numbers </summary>
/// <remarks> https://leetcode.com/problems/add-two-numbers/ </remarks>>
public sealed class AddTwoNumbersSolution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode resultRoot = null!;

        var currentNode = new ListNode();

        var inMemory = 0;
        while (l1 is not null || l2 is not null)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + inMemory;
            inMemory = sum / 10;
            currentNode.next = new ListNode(sum % 10);

            resultRoot ??= currentNode.next;
            l1 = l1?.next;
            l2 = l2?.next;
            currentNode = currentNode.next;
        }

        if (inMemory != 0)
            currentNode.next = new ListNode(inMemory);

        return resultRoot;
    }
}


