namespace LeetCode.UnitTests.Algorithms.Easy.LinkedList;

public sealed class RemoveDuplicatesFromSortedListSolutionTests
{
    [Theory]
    [InlineData(new[] { 1, 1, 2  }, new[] { 1, 2 })]
    [InlineData(new[] { 1, 1, 2, 2, 2, 3, 4, 4, 4  }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    public void Given_some_set_of_input_parameters_When_call_DeleteDuplicates_Then_should_return_correct_solutions(int[] head, int[] expectedSolution)
    {
        // Arrange
        var alg = new RemoveDuplicatesFromSortedListSolution();

        // Act
        var actualSolution = alg.DeleteDuplicates(LinkedListUtils.GetList(head));

        // Assert
        LinkedListUtils.GetDigits(actualSolution).Should().BeEquivalentTo(expectedSolution);
    }
    
    [Fact]
    public void Given_some_empty_set_of_input_parameters_When_call_DeleteDuplicates_Then_should_return_correct_solutions()
    {
        // Arrange
        var alg = new RemoveDuplicatesFromSortedListSolution();

        // Act
        var actualSolution = alg.DeleteDuplicates(LinkedListUtils.GetList(Array.Empty<int>()));

        // Assert
        LinkedListUtils.GetDigits(actualSolution).Should().BeEmpty();
    }
}
