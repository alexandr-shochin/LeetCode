namespace LeetCode.UnitTests.Algorithms.Easy.Stack;

public sealed class DecoderTests
{
    [Theory]
    [InlineData("2[g]ab2[b2[c1[h]d]3[e]]f", "ggabbchdchdeeebchdchdeeef")]
    [InlineData("2[a2[b2[c]]]", "abccbccabccbcc")]
    [InlineData("", "")]
    [InlineData(null, "")]
    public void Given_some_set_of_input_parameters_When_call_Decode_Then_should_return_correct_solutions(string inputStr, string expectedSolution)
    {
        // Arrange
        var alg = new Decoder();

        // Act
        var actualSolution = alg.Decode(inputStr);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
