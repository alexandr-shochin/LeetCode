using LeetCode.Concurrency.Easy;
using Xunit.Abstractions;

namespace LeetCode.UnitTests.Concurrency.Easy;

public sealed class PrintInOrderSolutionTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public PrintInOrderSolutionTests(ITestOutputHelper testOutputHelper) => _testOutputHelper = testOutputHelper;

    [Fact]
    public void Given_some_set_of_input_parameters_When_call_RomanToInt_Then_should_return_correct_solutions()
    {
        // Arrange
        const int ExperimentCount = 100;
        const string ExpectedSolution = "firstsecondthird";
        
        // Act and Assert
        for (var experimentNumber = 1; experimentNumber <= ExperimentCount; experimentNumber++)
        {
            var alg = new PrintInOrderSolution();
            
            var actualSolution = string.Empty;
            var threads = new[]
            {
                new Thread(_ => alg.First(() => actualSolution += "first")),
                new Thread(_ => alg.Second(() => actualSolution += "second")),
                new Thread(_ => alg.Third(() => actualSolution += "third"))
            };
            
            Parallel.ForEach(threads, thread => thread.Start());
            alg.ThirdManualResetEventSlim.Wait();
        
            actualSolution.Should().Be(ExpectedSolution);
            _testOutputHelper.WriteLine($"experimentNumber: {experimentNumber} OK!");
        }
    }
}
