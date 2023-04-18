using LeetCode.Algorithms.Easy;

namespace LeetCode.UnitTests.Algorithms.Easy;

public sealed class PalindromeNumberSolutionTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(123, false)]
    [InlineData(1221, true)]
    [InlineData(1231, false)]
    [InlineData(-1221, false)]
    [InlineData(3, true)]
    [InlineData(10, false)]
    public void Given_some_set_of_input_parameters_When_call_TwoSum_Then_should_return_correct_solutions(int x, bool expectedSolution)
    {
        // Arrange
        var alg = new PalindromeNumberSolution();

        // Act
        var actualSolution = alg.IsPalindrome(x);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
