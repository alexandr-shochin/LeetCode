namespace LeetCode.UnitTests.Algorithms.Easy;

public sealed class ValidParenthesesSolutionTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("", true)]
    [InlineData("()[", false)]
    [InlineData("{[]}", true)]
    [InlineData("{{{{(((([[[[]]]]))))}}}}", true)]
    [InlineData("([}}])", false)]
    [InlineData("([)]", false)] 
    [InlineData("((", false)]
    [InlineData("))", false)]
    public void Given_some_set_of_input_parameters_When_call_IsValid_Then_should_return_correct_solutions(string s, bool expectedSolution)
    {
        // Arrange
        var alg = new ValidParenthesesSolution();

        // Act
        var actualSolution = alg.IsValid(s);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
