namespace LeetCode.Algorithms.Medium.Tree;

public sealed class ListNode 
{
    public int Val { get; }
    public ListNode? Next { get; set; }

    public ListNode(int val = 0, ListNode? next = null)
    {
        Val = val;
        Next = next;
    }
}

/// <summary>2. Add Two Numbers</summary>
/// <remarks>https://leetcode.com/problems/add-two-numbers/</remarks>>
public sealed class AddTwoNumbersSolution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode resultRoot = null!;

        var currentNode = new ListNode();

        var inMemory = 0;
        while (l1 is not null || l2 is not null)
        {
            var sum = (l1?.Val ?? 0) + (l2?.Val ?? 0) + inMemory;
            inMemory = sum / 10;
            currentNode.Next = new ListNode(sum % 10);

            resultRoot ??= currentNode.Next;
            l1 = l1?.Next;
            l2 = l2?.Next;
            currentNode = currentNode.Next;
        }

        if (inMemory != 0)
            currentNode.Next = new ListNode(inMemory);

        return resultRoot;
    }
}


