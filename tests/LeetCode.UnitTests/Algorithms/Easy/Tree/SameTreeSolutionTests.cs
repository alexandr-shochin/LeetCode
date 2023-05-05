namespace LeetCode.UnitTests.Algorithms.Easy.Tree;

public sealed class SameTreeSolutionTests
{
    [Fact]
    public void Given_example_one_with_some_equivalent_trees_When_call_IsSameTree_Then_should_return_true()
    {
        // Arrange
        var alg = new SameTreeSolution();

        // Act
        var p = new TreeNode(
            1,
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(5)),
            new TreeNode(3,
                new TreeNode(6),
                new TreeNode(7)));
        var q = new TreeNode(
            1,
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(5)),
            new TreeNode(3,
                new TreeNode(6),
                new TreeNode(7)));
        var actualSolution = alg.IsSameTree(p, q);

        // Assert
        actualSolution.Should().BeTrue();
    }
    
    [Fact]
    public void Given_example_two_with_some_non_equivalent_trees_When_call_IsSameTree_Then_should_return_false()
    {
        // Arrange
        var alg = new SameTreeSolution();

        // Act
        var p = new TreeNode(
            1,
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(5)),
            new TreeNode(3,
                new TreeNode(6),
                new TreeNode(7)));
        var q = new TreeNode(
            1,
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(5)),
            new TreeNode(3,
                new TreeNode(6),
                new TreeNode(8)));
        var actualSolution = alg.IsSameTree(p, q);

        // Assert
        actualSolution.Should().BeFalse();
    }
    
    [Fact]
    public void Given_example_three_with_some_non_equivalent_trees_When_call_IsSameTree_Then_should_return_false()
    {
        // Arrange
        var alg = new SameTreeSolution();

        // Act
        var p = new TreeNode(
            1,
            left: new TreeNode(2));
        var q = new TreeNode(
            1,
            right: new TreeNode(2));
        var actualSolution = alg.IsSameTree(p, q);

        // Assert
        actualSolution.Should().BeFalse();
    }
    
    [Fact]
    public void Given_example_four_with_some_non_equivalent_trees_When_call_IsSameTree_Then_should_return_false()
    {
        // Arrange
        var alg = new SameTreeSolution();

        // Act
        var p = new TreeNode(
            1,
            new TreeNode(2),
            new TreeNode(1));
        var q = new TreeNode(
            1,
            new TreeNode(1),
            new TreeNode(2));
        var actualSolution = alg.IsSameTree(p, q);

        // Assert
        actualSolution.Should().BeFalse();
    }
    
    [Fact]
    public void Given_example_five_with_some_non_equivalent_trees_When_call_IsSameTree_Then_should_return_false()
    {
        // Arrange
        var alg = new SameTreeSolution();

        // Act
        var p = new TreeNode(
            10,
            left: new TreeNode(5),
            right: new TreeNode(15));
        var q = new TreeNode(
            10,
            left: new TreeNode(5,
                right: new TreeNode(15)));
        var actualSolution = alg.IsSameTree(p, q);

        // Assert
        actualSolution.Should().BeFalse();
    }
    
    [Fact]
    public void Given_example_six_with_some_non_equivalent_trees_When_call_IsSameTree_Then_should_return_false()
    {
        // Arrange
        var alg = new SameTreeSolution();

        // Act
        var p = new TreeNode(0);
        var q = new TreeNode(1);
        var actualSolution = alg.IsSameTree(p, q);

        // Assert
        actualSolution.Should().BeFalse();
    }
    
    [Fact]
    public void Given_example_seven_with_some_non_equivalent_trees_When_call_IsSameTree_Then_should_return_false()
    {
        // Arrange
        var alg = new SameTreeSolution();

        // Act
        TreeNode? p = null;
        var q = new TreeNode(0);
        var actualSolution = alg.IsSameTree(p, q);

        // Assert
        actualSolution.Should().BeFalse();
    }
    
    [Fact]
    public void Given_example_eight_with_null_trees_When_call_IsSameTree_Then_should_return_true()
    {
        // Arrange
        var alg = new SameTreeSolution();

        // Act
        TreeNode? p = null;
        TreeNode? q = null;
        var actualSolution = alg.IsSameTree(p, q);

        // Assert
        actualSolution.Should().BeTrue();
    }
}
