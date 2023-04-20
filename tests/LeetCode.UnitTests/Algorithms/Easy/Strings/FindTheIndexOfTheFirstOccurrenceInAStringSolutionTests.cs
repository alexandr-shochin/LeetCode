namespace LeetCode.UnitTests.Algorithms.Easy.Strings;

public sealed class FindTheIndexOfTheFirstOccurrenceInAStringSolutionTests
{
    [Theory]
    [InlineData("aaasadbutsad", "sad", 3)]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("leetcode", "", -1)]
    [InlineData("", "leeto", -1)]
    [InlineData("mississippi", "issip", 4)]
    [InlineData("aaa", "aaaa", -1)]
    [InlineData("mississippi", "issipi", -1)]
    public void Given_some_set_of_input_parameters_When_call_IsValid_Then_should_return_correct_solutions(string haystack, string needle, int expectedSolution)
    {
        // Arrange
        var alg = new FindTheIndexOfTheFirstOccurrenceInAStringSolution();

        // Act
        var actualSolution = alg.StrStr(haystack, needle);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
