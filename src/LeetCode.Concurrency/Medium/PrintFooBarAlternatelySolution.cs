namespace LeetCode.Concurrency.Medium;

/// <summary>1115. Print FooBar Alternately</summary>
/// <remarks>https://leetcode.com/problems/print-foobar-alternately/</remarks>
public sealed class PrintFooBarAlternatelySolution
{
    private readonly int _n;
    private readonly ManualResetEventSlim _firstManualResetEventSlim = new(false);
    private readonly ManualResetEventSlim _secondManualResetEventSlim = new(true);

    public PrintFooBarAlternatelySolution(int n) => _n = n;

    public ManualResetEventSlim FinishedManualResetEventSlim { get; } = new(false);

    public void Foo(Action printFoo)
    {
        for (var i = 0; i < _n; i++)
        {
            _secondManualResetEventSlim.Wait();
            _secondManualResetEventSlim.Reset();

            printFoo();
            
            _firstManualResetEventSlim.Set();
        }
    }

    public void Bar(Action printBar)
    {
        for (var i = 0; i < _n; i++)
        {
            _firstManualResetEventSlim.Wait();
            _firstManualResetEventSlim.Reset();
            
            printBar();
            
            _secondManualResetEventSlim.Set();
        }
        
        FinishedManualResetEventSlim.Set();
    }
}
