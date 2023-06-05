namespace LeetCode.UnitTests.Algorithms.Easy.String;

public sealed class ValidPalindromeSolutionTests
{
    [Theory]
    [InlineData("A mAn,A pLaN, a CaNaL: PaNaMa ", true)]
    [InlineData(" RaCe A & cAr", false)]
    [InlineData(" ", true)]
    [InlineData(".,", true)]
    public void Given_some_set_of_input_parameters_When_call_IsPalindrome_Then_should_return_correct_solutions(string s, bool expectedSolution)
    {
        // Arrange
        var alg = new ValidPalindromeSolution();

        // Act
        var actualSolution = alg.IsPalindrome(s);

        // Assert
        actualSolution.Should().Be(expectedSolution);
    }
}
