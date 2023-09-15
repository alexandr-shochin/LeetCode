namespace LeetCode.UnitTests.Algorithms.Easy.Stack;

public sealed class ValidParenthesesSolutionTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("", true)]
    [InlineData("()[", false)]
    [InlineData("{[]}", true)]
    [InlineData("{[]()}", true)]
    [InlineData("{{{{(((([[[[]]]]))))}}}}", true)]
    [InlineData("([}}])", false)]
    [InlineData("([)]", false)]
    [InlineData("((", false)]
    [InlineData("))", false)]
    [InlineData("(a`a(b!b(c#№(d$;(%ee(:^f(&?g(*hh(_ii(j-j(k+k(ll=(mm~)n<n)o>o)p,p)q/q)r|r)s1s)t:t)uUu)vvV)Www)xXx)yYy)zZz.", true)]
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
