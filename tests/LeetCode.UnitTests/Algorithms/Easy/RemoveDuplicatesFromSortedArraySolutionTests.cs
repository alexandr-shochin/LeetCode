namespace LeetCode.UnitTests.Algorithms.Easy;

public sealed class RemoveDuplicatesFromSortedArraySolutionTests
{
    [Theory]
    [InlineData(new [] { 1, 1, 2 }, 2, new [] { 1, 2 })]
    [InlineData(new [] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new [] { 0, 1, 2, 3, 4 })]
    [InlineData(new [] { 1, 1, 2, 2, 3, 3 }, 3, new [] { 1, 2, 3 })]
    public void Given_some_set_of_input_parameters_When_call_RemoveDuplicates_Then_should_return_correct_solutions(
        int[] nums, int expectedK, int[] expectedNums)
    {
        // Arrange
        var alg = new RemoveDuplicatesFromSortedArraySolution();

        // Act
        var actualSolution = alg.RemoveDuplicates(nums);

        // Assert
        actualSolution.Should().Be(expectedK);

        for (var expectedIndex = 0; expectedIndex < expectedK; expectedIndex++)
            nums[expectedIndex].Should().Be(expectedNums[expectedIndex]);
    }
}
