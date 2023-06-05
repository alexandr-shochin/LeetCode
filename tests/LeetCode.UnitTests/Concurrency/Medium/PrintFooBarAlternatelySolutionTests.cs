namespace LeetCode.UnitTests.Concurrency.Medium;

public sealed class PrintFooBarAlternatelySolutionTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public PrintFooBarAlternatelySolutionTests(ITestOutputHelper testOutputHelper) => _testOutputHelper = testOutputHelper;

    [Fact]
    public void Given_some_set_of_input_parameters_When_call_Bar_and_Foo_Then_should_return_correct_solutions()
    {
        // Arrange
        const int ExperimentCount = 100;
        
        // Act and Assert
        for (var experimentNumber = 1; experimentNumber <= ExperimentCount; experimentNumber++)
        {
            var alg = new PrintFooBarAlternatelySolution(experimentNumber);
            
            var actualSolution = string.Empty;
            var threads = new[]
            {
                new Thread(_ => alg.Bar(() => actualSolution += "bar")),
                new Thread(_ => alg.Foo(() => actualSolution += "foo"))
            };
            
            Parallel.ForEach(threads, thread => thread.Start());
            alg.FinishedManualResetEventSlim.Wait();
            
            var expectedSolution = string.Empty;
            for (var i = 1; i <= experimentNumber; i++)
                expectedSolution += "foobar";
            
            actualSolution.Should().Be(expectedSolution);
            _testOutputHelper.WriteLine($"experimentNumber: {experimentNumber} OK!");
        }
    }
}
