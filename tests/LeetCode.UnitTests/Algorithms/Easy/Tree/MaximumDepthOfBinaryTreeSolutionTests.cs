namespace LeetCode.UnitTests.Algorithms.Easy.Tree;

public sealed class MaximumDepthOfBinaryTreeSolutionTests
{
    [Fact]
    public void Given_some_set_of_input_parameters_When_call_RomanToInt_Then_should_return_correct_solutions()
    {
        // Arrange
        var alg = new MaximumDepthOfBinaryTreeSolution();

        // Act
        var tree = new TreeNode(
            3,
            left: new TreeNode(9),
            right: new TreeNode(
                20,
                left: new TreeNode(15),
                right: new TreeNode(7,
                    left: new TreeNode(2),
                    right: new TreeNode(5))));
        var actualSolution = alg.MaxDepth(tree);

        // Assert
        actualSolution.Should().Be(4);
    }
}
