namespace LeetCode.UnitTests.Algorithms.Easy.Math;

public sealed class SqrtXSolutionTests
{
    [Theory]
    [InlineData(9, 3)]
    [InlineData(8, 2)]
    [InlineData(1, 1)]
    [InlineData(0, 0)]
    [InlineData(2, 1)]
    [InlineData(4, 2)]
    [InlineData(49, 7)]
    [InlineData(100, 10)]
    [InlineData(2147395600, 46340)]
    [InlineData(int.MaxValue, 46340)]
    public void Given_some_set_of_input_parameters_When_call_MySqrt_Then_should_return_correct_solutions(int x, int expectedSolution)
    {
        // Arrange
        var alg = new SqrtXSolution();

        // Act
        var actualSolution = alg.MySqrt(x);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }

    [Fact]
    public void Given_all_perfect_squares_up_to_the_maximum_value_When_call_MySqrt_Then_should_return_the_exact_square_root()
    {
        // Arrange
        var alg = new SqrtXSolution();

        // Act and Assert
        for (var expectedRoot = 0; expectedRoot <= 46340; expectedRoot++)
        {
            var actualSolution = alg.MySqrt(expectedRoot * expectedRoot);

            actualSolution.Should().Be(expectedRoot, $"MySqrt({expectedRoot * expectedRoot}) should be {expectedRoot}");
        }
    }

    [Fact]
    public void Given_values_around_perfect_squares_When_call_MySqrt_Then_should_return_the_floor_square_root()
    {
        // Arrange
        var alg = new SqrtXSolution();

        // Act and Assert
        for (var root = 1; root <= 46340; root++)
        {
            alg.MySqrt(root * root + 1).Should().Be(root);

            if (root > 1)
                alg.MySqrt(root * root - 1).Should().Be(root - 1);
        }
    }
}
