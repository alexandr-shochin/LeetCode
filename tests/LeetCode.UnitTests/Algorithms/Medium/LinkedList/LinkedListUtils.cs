namespace LeetCode.UnitTests.Algorithms.Medium.LinkedList;

public static class LinkedListUtils
{
    public static ListNode? GetList(int[] listNodes)
    {
        if (listNodes is { Length: 0 })
            return null;
        
        var currentNode = new ListNode(listNodes[listNodes.Length - 1]);
        for (var i = listNodes.Length - 2; i >= 0 ; i--)
        {
            var newNode  = new ListNode(listNodes[i], currentNode);
            currentNode = newNode;
        }

        return currentNode;
    }

    public static int[] GetDigits(ListNode? listNode)
    {
        if(listNode is null)
            return Array.Empty<int>();
        
        var digits = new List<int> { listNode.val };

        var root = listNode;
        while (root.next is { } next)
        {
            digits.Add(next.val);
            root = next;
        }

        return digits.ToArray();
    }
}
