namespace LeetCode.UnitTests.Algorithms.Easy.Arrays;

public sealed class PlusOneSolutionTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [InlineData(new[] { 1, 2, 3, 9 }, new[] { 1, 2, 4, 0 })]
    [InlineData(new[] { 9 }, new[] { 1, 0 })]
    public void Given_some_set_of_input_parameters_When_call_PlusOne_Then_should_return_correct_solutions(int[] digits, int[] expectedSolution)
    {
        // Arrange
        var alg = new PlusOneSolution();

        // Act
        var actualSolution = alg.PlusOne(digits);

        // Assert
        actualSolution.Should().BeEquivalentTo(expectedSolution);
    }
}
