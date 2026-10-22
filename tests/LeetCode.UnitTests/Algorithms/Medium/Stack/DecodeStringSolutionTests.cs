namespace LeetCode.UnitTests.Algorithms.Medium.Stack;

public sealed class DecodeStringSolutionTests
{
    [Theory]
    [InlineData("2[g]ab2[b2[c1[h]d]3[e]]f", "ggabbchdchdeeebchdchdeeef")]
    [InlineData("2[a2[b2[c]]]", "abccbccabccbcc")]
    [InlineData("3[a]2[bc]", "aaabcbc")]
    [InlineData("2[abc]3[cd]ef", "abcabccdcdcdef")]
    [InlineData("12[a]", "aaaaaaaaaaaa")]
    [InlineData("ab]c", "ab]c")]
    [InlineData("", "")]
    public void Given_some_set_of_input_parameters_When_call_DecodeString_Then_should_return_correct_solutions(string inputStr, string expectedSolution)
    {
        // Arrange
        var alg = new DecodeStringSolution();

        // Act
        var actualSolution = alg.DecodeString(inputStr);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }

    [Fact]
    public void Given_null_input_When_call_DecodeString_Then_should_throw_ArgumentNullException()
    {
        // Arrange
        var alg = new DecodeStringSolution();

        // Act
        var act = () => alg.DecodeString(null!);

        // Assert
        act.Should().Throw<ArgumentNullException>();
    }
}
