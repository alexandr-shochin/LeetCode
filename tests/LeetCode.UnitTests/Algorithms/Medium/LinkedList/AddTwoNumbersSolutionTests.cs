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
        var firstListNode = LinkedListUtils.GetList(l1);
        var secondListNode = LinkedListUtils.GetList(l2);

        // Act
        var actualSolution = alg.AddTwoNumbers(firstListNode, secondListNode);

        // Assert
        LinkedListUtils.GetDigits(actualSolution).Should().BeEquivalentTo(expectedSolution);
    }
}
