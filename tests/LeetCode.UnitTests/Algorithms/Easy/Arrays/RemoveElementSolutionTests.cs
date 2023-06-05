namespace LeetCode.UnitTests.Algorithms.Easy.Arrays;

public sealed class RemoveElementSolutionTests
{
    [Theory]
    [InlineData(new [] { 3, 2, 2, 3 }, 3, 2, new [] { 2, 2 })]
    [InlineData(new [] { 3, 3, 2, 3 }, 3, 1, new [] { 2 })]
    [InlineData(new [] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new [] { 0, 0, 1, 3, 4 })]
    [InlineData(new [] { 1, 1, 2, 2, 3, 2, 4, 1 }, 2, 5, new [] { 1, 1, 1, 3, 4 })]
    public void Given_some_set_of_input_parameters_When_call_RemoveElement_Then_should_return_correct_solutions(
        int[] nums, int val, int expectedK, int[] expectedNums)
    {
        // Arrange
        var alg = new RemoveElementSolution();

        // Act
        var actualSolution = alg.RemoveElement(nums, val);

        // Assert
        actualSolution.Should().Be(expectedK);
        Array.Sort(nums, 0, actualSolution);
        for (var expectedIndex = 0; expectedIndex < expectedK; expectedIndex++)
            nums[expectedIndex].Should().Be(expectedNums[expectedIndex]);
    }
}
