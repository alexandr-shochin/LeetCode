namespace LeetCode.UnitTests.Algorithms.Medium.LinkedList;

public sealed class AddTwoNumbersSolutionTests
{
    [Theory]
    [InlineData(new[] { 2, 4, 7  }, new[] { 5, 6, 4 }, new[] { 7, 0, 2, 1 })]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    [InlineData(
        new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, 
        new[] { 5, 6, 4 },
        new[] { 6, 6, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 })]
    public void Given_some_set_of_input_parameters_When_call_AddTwoNumbers_Then_should_return_correct_solutions(int[] l1, int[] l2, int[] expectedSolution)
    {
        // Arrange
        var alg = new AddTwoNumbersSolution();
        var firstListNode = GetList(l1);
        var secondListNode = GetList(l2);

        // Act
        var actualSolution = alg.AddTwoNumbers(firstListNode, secondListNode);

        // Assert
        GetDigits(actualSolution).Should().BeEquivalentTo(expectedSolution);
    }

    private ListNode GetList(int[] listNode)
    {
        var currentNode = new ListNode(listNode[listNode.Length - 1]);
        for (var i = listNode.Length - 2; i >= 0 ; i--)
        {
            var newNode  = new ListNode(listNode[i], currentNode);
            currentNode = newNode;
        }

        return currentNode;
    }

    private int[] GetDigits(ListNode listNode)
    {
        var digits = new List<int> { listNode.Val };

        var root = listNode;
        while (root.Next is { } next)
        {
            digits.Add(next.Val);
            root = next;
        }

        return digits.ToArray();
    }
}
