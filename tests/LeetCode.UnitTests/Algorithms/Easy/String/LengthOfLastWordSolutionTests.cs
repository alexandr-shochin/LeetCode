namespace LeetCode.UnitTests.Algorithms.Easy.String;

public sealed class LengthOfLastWordSolutionTests
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    [InlineData("", 0)]
    [InlineData(null, 0)]
    [InlineData(" ", 0)]
    [InlineData("a", 1)]
    public void Given_some_set_of_input_parameters_When_call_RomanToInt_Then_should_return_correct_solutions(string s, int expectedSolution)
    {
        // Arrange
        var alg = new LengthOfLastWordSolution();

        // Act
        var actualSolution = alg.LengthOfLastWord(s);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
