using LeetCode.Algorithms.Easy.Math;

namespace LeetCode.UnitTests.Algorithms.Easy.Math;

public sealed class SqrtXSolutionTests
{
    [Theory]
    [InlineData(9, 3)]
    [InlineData(8, 2)]
    [InlineData(1, 1)]
    public void Given_some_set_of_input_parameters_When_call_IsValid_Then_should_return_correct_solutions(int x, int expectedSolution)
    {
        // Arrange
        var alg = new SqrtXSolution();

        // Act
        var actualSolution = alg.MySqrt(x);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
