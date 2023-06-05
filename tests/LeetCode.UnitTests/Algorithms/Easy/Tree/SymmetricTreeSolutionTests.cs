namespace LeetCode.UnitTests.Algorithms.Easy.Tree;

public sealed class SymmetricTreeSolutionTests
{
    [Fact]
    public void Given_some_symmetric_tree_v1_When_call_IsSymmetric_Then_should_return_true()
    {
        // Arrange
        var alg = new SymmetricTreeSolution();

        // Act
        var root = new TreeNode(
            1,
            new TreeNode(2, 
                new TreeNode(3),
                new TreeNode(4)),
            new TreeNode(2, 
                new TreeNode(4),
                new TreeNode(3)));
        var actualSolution = alg.IsSymmetric(root);

        // Assert
        actualSolution.Should().BeTrue();
    }
    
    [Fact]
    public void Given_some_symmetric_tree_v2_When_call_IsSymmetric_Then_should_return_true()
    {
        // Arrange
        var alg = new SymmetricTreeSolution();

        // Act
        var root = new TreeNode(
            1,
            new TreeNode(2, 
                left:new TreeNode(3)),
            new TreeNode(2,
                right: new TreeNode(3)));
        var actualSolution = alg.IsSymmetric(root);

        // Assert
        actualSolution.Should().BeTrue();
    }
    
    [Fact]
    public void Given_some_asymmetric_tree_v1_When_call_IsSymmetric_Then_should_return_false()
    {
        // Arrange
        var alg = new SymmetricTreeSolution();

        // Act
        var root = new TreeNode(
            1,
            new TreeNode(2, 
                null,
                new TreeNode(3)),
            new TreeNode(2, 
                null,
                new TreeNode(3)));
        var actualSolution = alg.IsSymmetric(root);

        // Assert
        actualSolution.Should().BeFalse();
    }
    
    [Fact]
    public void Given_some_asymmetric_tree_v2_When_call_IsSymmetric_Then_should_return_false()
    {
        // Arrange
        var alg = new SymmetricTreeSolution();

        // Act
        var root = new TreeNode(
            9,
            new TreeNode(-42, 
                null,
                new TreeNode(76,
                    null,
                    new TreeNode(13))),
            new TreeNode(-42,
                new TreeNode(76,
                    null,
                    new TreeNode(13))));
        var actualSolution = alg.IsSymmetric(root);

        // Assert
        actualSolution.Should().BeFalse();
    }
}
