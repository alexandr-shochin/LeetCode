namespace LeetCode.Algorithms;

public sealed class Decoder
{
    public string Decode(string inputStr)
    {
        if (string.IsNullOrEmpty(inputStr))
            return string.Empty;
        
        var stack = new Stack<string>();
        
        foreach (var inputSymbol in inputStr)
        {
            var inputStringSymbol = inputSymbol.ToString();
            
            stack.Push(inputStringSymbol);

            if (inputStringSymbol is not "]")
                continue;

            var subStr = ExtractSubStr(stack);
            var multipliedStr = MultiplyStr(subStr);
            stack.Push(multipliedStr);
        }

        var result = string.Empty;
        while (stack is not { Count: 0 })
            result = string.Concat(stack.Pop(), result);
        
        return result;
    }

    private string ExtractSubStr(Stack<string> stack)
    {
        var result = string.Empty;
        
        while (!IsDigit(stack.Peek()))
            result = string.Concat(stack.Pop(), result);
        result = string.Concat(stack.Pop(), result);

        return result;
    }

    private string MultiplyStr(string inputStr)
    {
        var result = string.Empty;
        
        var multiplyFactor = int.Parse(inputStr.First().ToString());
        var endIndexOfInputStr = inputStr.Length - 2;
        for (var factorIdx = 1; factorIdx <= multiplyFactor; ++factorIdx)
            for (var inputStrIdx = 2; inputStrIdx <= endIndexOfInputStr; ++inputStrIdx)
                result = string.Concat(result, inputStr[inputStrIdx]);

        return result;
    }

    private bool IsDigit(string str) => int.TryParse(str, out _);
}
