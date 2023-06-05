namespace LeetCode.UnitTests.Algorithms.Easy.Tree;

public sealed class InvertBinaryTreeSolutionTests
{
    [Fact]
    public void Given_some_set_of_input_parameters_When_call_InvertTree_Then_should_return_correct_solutions()
    {
        // Arrange
        var alg = new InvertBinaryTreeSolution();

        // Act
        var root = new TreeNode(
            4,
            new TreeNode(2, 
                new TreeNode(1),
                new TreeNode(3)),
            new TreeNode(7, 
                new TreeNode(6),
                new TreeNode(9)));
        var actualSolution = alg.InvertTree(root);

        // Assert
        actualSolution!.val.Should().Be(4);
        
        actualSolution.left!.val.Should().Be(7);
        actualSolution.left.left!.val.Should().Be(9);
        actualSolution.left.right!.val.Should().Be(6);
        
        actualSolution.right!.val.Should().Be(2);
        actualSolution.right.left!.val.Should().Be(3);
        actualSolution.right.right!.val.Should().Be(1);
    }
}
