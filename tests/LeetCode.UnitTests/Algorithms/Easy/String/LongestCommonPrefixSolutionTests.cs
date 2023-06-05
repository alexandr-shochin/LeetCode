namespace LeetCode.UnitTests.Algorithms.Easy.String;

public sealed class LongestCommonPrefixSolutionTests
{
    [Theory]
    [InlineData(new[] { "flower","flow","flight" }, "fl")]
    [InlineData(new[] { "qwertyui","qwertyuiasdf","qwertyuiqwer" }, "qwertyui")]
    [InlineData(new[] { "dog","racecar","car" }, "")]
    [InlineData(new[] { "", "racecar","car" }, "")]
    [InlineData(new[] { "vfbdsfdfa" }, "vfbdsfdfa")]
    public void Given_some_set_of_input_parameters_When_call_LongestCommonPrefix_Then_should_return_correct_solutions(string[] strings, string expectedSolution)
    {
        // Arrange
        var alg = new LongestCommonPrefixSolution();

        // Act
        var actualSolution = alg.LongestCommonPrefix(strings);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
    
    [Fact]
    public void Given_empty_input_strings_array_When_call_LongestCommonPrefix_Then_should_return_empty_solution()
    {
        // Arrange
        var alg = new LongestCommonPrefixSolution();
        var strings = Array.Empty<string>();
        var expectedSolution = string.Empty;

        // Act
        var actualSolution = alg.LongestCommonPrefix(strings);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
