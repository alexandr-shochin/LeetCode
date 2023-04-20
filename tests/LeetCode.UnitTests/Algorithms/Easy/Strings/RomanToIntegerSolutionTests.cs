namespace LeetCode.UnitTests.Algorithms.Easy.Strings;

public sealed class RomanToIntegerSolutionTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
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
