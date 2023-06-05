namespace LeetCode.UnitTests.Algorithms.Easy.String;

public sealed class AddBinarySolutionTests
{
    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("11", "11", "110")]
    [InlineData("1010", "1011", "10101")]
    public void Given_some_set_of_input_parameters_When_call_AddBinary_Then_should_return_correct_solutions(string a, string b, string expectedSolution)
    {
        // Arrange
        var alg = new AddBinarySolution();

        // Act
        var actualSolution = alg.AddBinary(a, b);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
