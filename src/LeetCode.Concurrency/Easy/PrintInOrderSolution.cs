namespace LeetCode.Concurrency.Easy;

/// <summary>1114. Print in Order</summary>
/// <remarks>https://leetcode.com/problems/print-in-order/</remarks>>
public sealed class PrintInOrderSolution
{
    private readonly ManualResetEventSlim _firstManualResetEventSlim = new(false);
    private readonly ManualResetEventSlim _secondManualResetEventSlim = new(false);
    
    public PrintInOrderSolution()
    {
    }

    public void First(Action printFirst)
    {
        printFirst();

        _firstManualResetEventSlim.Set();
    }

    public void Second(Action printSecond)
    {
        _firstManualResetEventSlim.Wait();

        printSecond();

        _secondManualResetEventSlim.Set();
    }

    public void Third(Action printThird)
    {
        _secondManualResetEventSlim.Wait();

        printThird();
    }
}
