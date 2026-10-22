namespace LeetCode.Concurrency.Medium;

/// <summary>1115. Print FooBar Alternately</summary>
/// <remarks>https://leetcode.com/problems/print-foobar-alternately/</remarks>
public sealed class PrintFooBarAlternatelySolution
{
    private readonly int _n;
    private readonly ManualResetEventSlim _firstPrinted = new(false);
    private readonly ManualResetEventSlim _secondPrinted = new(true);

    public PrintFooBarAlternatelySolution(int n) => _n = n;

    public void Foo(Action printFoo)
    {
        for (var i = 0; i < _n; i++)
        {
            _secondPrinted.Wait();
            _secondPrinted.Reset();

            printFoo();

            _firstPrinted.Set();
        }
    }

    public void Bar(Action printBar)
    {
        for (var i = 0; i < _n; i++)
        {
            _firstPrinted.Wait();
            _firstPrinted.Reset();

            printBar();

            _secondPrinted.Set();
        }
    }
}
