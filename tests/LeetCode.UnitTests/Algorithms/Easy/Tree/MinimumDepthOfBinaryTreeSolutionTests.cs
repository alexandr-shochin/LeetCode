namespace LeetCode.UnitTests.Algorithms.Easy.Tree;

public sealed class MinimumDepthOfBinaryTreeSolutionTests
{
    [Fact]
    public void Given_some_set_of_input_parameters_When_call_MinDepth_Then_should_return_correct_solutions()
    {
        // Arrange
        var alg = new MinimumDepthOfBinaryTreeSolution();

        // Act
        var tree = new TreeNode(
            3,
            left: new TreeNode(9,
                left: new TreeNode(8)),
            right: new TreeNode(
                20,
                left: new TreeNode(15),
                right: new TreeNode(7,
                    left: new TreeNode(2),
                    right: new TreeNode(5))));
        var actualSolution = alg.MinDepth(tree);

        // Assert
        actualSolution.Should().Be(3);
    }
}
