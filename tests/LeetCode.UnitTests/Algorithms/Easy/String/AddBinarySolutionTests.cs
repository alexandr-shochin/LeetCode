namespace LeetCode.UnitTests.Algorithms.Easy.String;

public sealed class AddBinarySolutionTests
{
    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("11", "11", "110")]
    [InlineData("1010", "1011", "10101")]
    [InlineData("0", "0", "0")]
    [InlineData("0", "1", "1")]
    [InlineData("1111", "1", "10000")]
    [InlineData("1", "1111", "10000")]
    public void Given_some_set_of_input_parameters_When_call_AddBinary_Then_should_return_correct_solutions(string a, string b, string expectedSolution)
    {
        // Arrange
        var alg = new AddBinarySolution();

        // Act
        var actualSolution = alg.AddBinary(a, b);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }

    [Theory]
    [InlineData(null, "1")]
    [InlineData("1", null)]
    [InlineData("", "1")]
    [InlineData("1", "")]
    [InlineData(" ", "1")]
    [InlineData("1", " ")]
    public void Given_null_or_empty_input_When_call_AddBinary_Then_should_throw_ArgumentException(string? a, string? b)
    {
        // Arrange
        var alg = new AddBinarySolution();

        // Act
        var act = () => alg.AddBinary(a!, b!);

        // Assert
        act.Should().Throw<ArgumentException>();
    }
}
