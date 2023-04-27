namespace LeetCode.UnitTests.Algorithms.Easy.LinkedList;

public sealed class MergeTwoSortedListsSolutionTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new[] { 1, 2, 4 }, new[] { 2, 3, 4 }, new[] { 1, 2, 2, 3, 4, 4 })]
    [InlineData(null!, new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 0 }, null!, new[] { 0 })]
    [InlineData(new[] { 2 }, new[] { 1 }, new[] { 1, 2 })]
    [InlineData(new[] { -10, -10, -9, -4, 1, 6, 6 }, new[] { -7 }, new[] { -10, -10, -9, -7, -4, 1, 6, 6 })]
    public void Given_some_set_of_input_parameters_When_call_AddTwoNumbers_Then_should_return_correct_solutions(int[]? l1, int[]? l2, int[] expectedSolution)
    {
        // Arrange
        var alg = new MergeTwoSortedListsSolution();
        var firstListNode = LinkedListUtils.GetList(l1);
        var secondListNode = LinkedListUtils.GetList(l2);

        // Act
        var actualSolution = alg.MergeTwoLists(firstListNode, secondListNode);

        // Assert
        LinkedListUtils.GetDigits(actualSolution).Should().BeEquivalentTo(expectedSolution);
    }
    
    [Fact]
    public void Given_some_empty_set_of_input_parameters_When_call_AddTwoNumbers_Then_should_return_correct_solutions()
    {
        // Arrange
        var alg = new MergeTwoSortedListsSolution();
        var firstListNode = LinkedListUtils.GetList(null!);
        var secondListNode = LinkedListUtils.GetList(null!);

        // Act
        var actualSolution = alg.MergeTwoLists(firstListNode, secondListNode);

        // Assert
        LinkedListUtils.GetDigits(actualSolution).Should().BeEquivalentTo(Array.Empty<int>());
    }
}
