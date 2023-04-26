namespace LeetCode.UnitTests.Algorithms.Easy.Arrays;

public sealed class TwoSumSolutionTests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [InlineData(new[] { -1, 2, 5, 8 }, 7, new[] { 1, 2 })]
    [InlineData(new[] { -3, -1, 0, 2, 6 }, 6, new[] { 2, 4 })]
    [InlineData(new[] { -2, -1, 1, 2 }, 0, new[] { 1, 2 })]
    public void Given_some_set_of_input_parameters_When_call_TwoSum_Then_should_return_correct_solutions(int[] nums, int target, int[] expectedSolution)
    {
        // Arrange
        var alg = new TwoSumSolution();

        // Act
        var actualSolution = alg.TwoSum(nums, target);

        // Assert
        actualSolution.Should().BeEquivalentTo(expectedSolution);
    }
    
    [Fact]
    public void Given_empty_input_nums_array_When_call_TwoSum_Then_should_return_empty_solution()
    {
        // Arrange
        var alg = new TwoSumSolution();
        var nums = Array.Empty<int>();
        var target = 0;
        var expectedSolution = Array.Empty<int>();

        // Act
        var actualSolution = alg.TwoSum(nums, target);

        // Assert
        actualSolution.Should().BeEquivalentTo(expectedSolution);
    }
    
    [Fact]
    public void Given_some_set_of_input_parameters_When_call_TwoSum_with_target_that_does_not_exist_Then_should_return_empty_solution()
    {
        // Arrange
        var alg = new TwoSumSolution();
        var nums = new[] { 2, 7, 11, 15 };
        var target = 8;
        var expectedSolution = Array.Empty<int>();

        // Act
        var actualSolution = alg.TwoSum(nums, target);

        // Assert
        actualSolution.Should().BeEquivalentTo(expectedSolution);
    }
}
