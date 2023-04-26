namespace LeetCode.UnitTests.Algorithms.Easy.Arrays;

public sealed class SearchInsertPositionSolutionTest
{
    [Theory]
    [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
    public void Given_some_set_of_input_parameters_When_call_TwoSum_Then_should_return_correct_solutions(int[] nums, int target, int expectedSolution)
    {
        // Arrange
        var alg = new SearchInsertPositionSolution();

        // Act
        var actualSolution = alg.SearchInsert(nums, target);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
