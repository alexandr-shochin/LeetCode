namespace LeetCode.UnitTests.Algorithms.Easy.Tree;

public sealed class MaximumDepthOfBinaryTreeSolutionTests
{
    [Fact]
    public void Given_null_root_When_call_MaxDepth_Then_should_return_zero()
    {
        // Arrange
        var alg = new MaximumDepthOfBinaryTreeSolution();

        // Act
        var actualSolution = alg.MaxDepth(null);

        // Assert
        actualSolution.Should().Be(0);
    }

    [Fact]
    public void Given_some_set_of_input_parameters_When_call_MaxDepth_Then_should_return_correct_solutions()
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

    [Fact]
    public void Given_multiple_calls_on_the_same_instance_When_call_MaxDepth_Then_should_not_leak_state_between_calls()
    {
        // Arrange
        var alg = new MaximumDepthOfBinaryTreeSolution();

        var deepTree = new TreeNode(1, left: new TreeNode(2, left: new TreeNode(3)));
        var shallowTree = new TreeNode(1, left: new TreeNode(2));

        // Act
        var firstSolution = alg.MaxDepth(deepTree);
        var secondSolution = alg.MaxDepth(shallowTree);

        // Assert
        firstSolution.Should().Be(3);
        secondSolution.Should().Be(2);
    }
}
