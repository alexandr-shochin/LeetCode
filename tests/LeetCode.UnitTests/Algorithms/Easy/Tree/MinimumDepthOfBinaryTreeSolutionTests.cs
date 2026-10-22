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

    [Fact]
    public void Given_null_root_When_call_MinDepth_Then_should_return_zero()
    {
        // Arrange
        var alg = new MinimumDepthOfBinaryTreeSolution();

        // Act
        var actualSolution = alg.MinDepth(null);

        // Assert
        actualSolution.Should().Be(0);
    }

    [Fact]
    public void Given_single_node_tree_When_call_MinDepth_Then_should_return_one()
    {
        // Arrange
        var alg = new MinimumDepthOfBinaryTreeSolution();

        // Act
        var actualSolution = alg.MinDepth(new TreeNode(1));

        // Assert
        actualSolution.Should().Be(1);
    }

    [Fact]
    public void Given_multiple_calls_on_the_same_instance_When_call_MinDepth_Then_should_not_leak_state_between_calls()
    {
        // Arrange
        var alg = new MinimumDepthOfBinaryTreeSolution();

        var shallowTree = new TreeNode(
            1,
            left: new TreeNode(2),
            right: new TreeNode(3));
        var deepTree = new TreeNode(
            1,
            left: new TreeNode(
                2,
                left: new TreeNode(
                    3,
                    left: new TreeNode(4))));

        // Act
        var firstSolution = alg.MinDepth(shallowTree);
        var secondSolution = alg.MinDepth(deepTree);

        // Assert
        firstSolution.Should().Be(2);
        secondSolution.Should().Be(4);
    }
}
