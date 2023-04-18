namespace LeetCode.Algorithms.Easy;

public sealed class RomanToIntegerSolution
{
    private static readonly IReadOnlyDictionary<string, int> ValueBySymbol = new Dictionary<string, int>
    {
        ["I"] = 1,
        ["IV"] = 4,
        ["V"] = 5,
        ["IX"] = 9,
        ["X"] = 10,
        ["XL"] = 40,
        ["L"] = 50,
        ["XC"] = 90,
        ["C"] = 100,
        ["CD"] = 400,
        ["D"] = 500,
        ["CM"] = 900,
        ["M"] = 1000,
    };
    
    public int RomanToInt(string s)
    {
        var len = s.Length;
        
        var result = 0;
        for (var i = 0; i < len; i++)
        {
            if(i + 1 < len && ValueBySymbol.TryGetValue(s.Substring(i, 2), out var value))
            {
                result += value;
                i++;
                
                continue;
            }

            if(ValueBySymbol.TryGetValue(s.Substring(i, 1), out value))
                result += value;
        }

        return result;
    }
}
