namespace LeetCode.UnitTests.Algorithms.Easy.String;

public sealed class RomanToIntegerSolutionTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    [InlineData("I", 1)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("XL", 40)]
    [InlineData("XC", 90)]
    [InlineData("CD", 400)]
    [InlineData("CM", 900)]
    [InlineData("MMMCMXCIX", 3999)]
    [InlineData("", 0)]
    [InlineData("A", 0)]
    public void Given_some_set_of_input_parameters_When_call_RomanToInt_Then_should_return_correct_solutions(string s, int expectedSolution)
    {
        // Arrange
        var alg = new RomanToIntegerSolution();

        // Act
        var actualSolution = alg.RomanToInt(s);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
