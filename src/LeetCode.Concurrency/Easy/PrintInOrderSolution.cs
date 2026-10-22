namespace LeetCode.Concurrency.Easy;

/// <summary>1114. Print in Order</summary>
/// <remarks>https://leetcode.com/problems/print-in-order/</remarks>
public sealed class PrintInOrderSolution
{
    private readonly ManualResetEventSlim _firstPrinted = new(false);
    private readonly ManualResetEventSlim _secondPrinted = new(false);

    public void First(Action printFirst)
    {
        printFirst();

        _firstPrinted.Set();
    }

    public void Second(Action printSecond)
    {
        _firstPrinted.Wait();

        printSecond();

        _secondPrinted.Set();
    }

    public void Third(Action printThird)
    {
        _secondPrinted.Wait();

        printThird();
    }
}
