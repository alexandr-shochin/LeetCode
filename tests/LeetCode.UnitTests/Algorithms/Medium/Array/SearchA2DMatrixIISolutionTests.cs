namespace LeetCode.UnitTests.Algorithms.Medium.Array;

public sealed class SearchA2DMatrixIISolutionTests
{
    private readonly int[][] _matrix;

    public SearchA2DMatrixIISolutionTests()
    {
        _matrix = new int[5][];
        _matrix[0] = new[] { 1, 4, 7, 11, 15 };
        _matrix[1] = new[] { 2, 5, 8, 12, 19 };
        _matrix[2] = new[] { 3, 6, 9, 16, 22 };
        _matrix[3] = new[] { 10, 13, 14, 17, 24 };
        _matrix[4] = new[] { 18, 21, 23, 26, 30 };
    }
    
    [Fact]
    public void Given_some_correct_matrix_When_call_SearchMatrix_with_target_that_exists_Then_should_return_true()
    {
        // Arrange
        var alg = new SearchA2DMatrixIISolution();

        // Act and Assert
        var columnsCount = _matrix[0].Length;
        var rowsCount = _matrix.Length;
        for (var columnIndex = 0; columnIndex < columnsCount - 1; columnIndex++)
        {
            for (var rowIndex = 0; rowIndex < rowsCount - 1; rowIndex++)
            {
                var actualSolution = alg.SearchMatrix(_matrix, _matrix[rowIndex][columnIndex]);
                actualSolution.Should().BeTrue();
            }
        }
    }
    
    [Fact]
    public void Given_some_correct_matrix_When_call_SearchMatrix_with_target_that_does_not_exists_Then_should_return_false()
    {
        // Arrange
        var alg = new SearchA2DMatrixIISolution();
        
        // Act
        var actualSolution = alg.SearchMatrix(_matrix, 25);
        
        // Assert
        actualSolution.Should().BeFalse();
    }
}
