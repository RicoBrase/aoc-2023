using System.Text;

namespace day01_lib;

public static class Part2
{
    private static readonly Dictionary<string, int> _digits = new()
    {
        {"one", 1},
        {"two", 2},
        {"three", 3},
        {"four", 4},
        {"five", 5},
        {"six", 6},
        {"seven", 7},
        {"eight", 8},
        {"nine", 9},
    };
    
    public static string PreprocessLine(string input)
    {
        var processedLine = new StringBuilder();
        var checkingLastCharOfFoundDigit = false;
        
        for (var outerIdx = 0; outerIdx < input.Length; outerIdx++)
        {
            var remainingSubStr = input[outerIdx..];
            var digitFound = false;
            
            foreach (var digit in _digits)
            {
                if (remainingSubStr.StartsWith(digit.Key))
                {
                    digitFound = true;
                    checkingLastCharOfFoundDigit = true;
                    processedLine.Append(digit.Value);
                    outerIdx += digit.Key.Length - 2;
                    break;
                }
            }

            if (!digitFound && !checkingLastCharOfFoundDigit)
            {
                processedLine.Append(input[outerIdx]);
            }
            
            if (!digitFound && checkingLastCharOfFoundDigit)
            {
                checkingLastCharOfFoundDigit = false;
            }
        }
        
        return processedLine.ToString();
    }
    
    public static string PreprocessLine_Backup(string input)
    {
        var processedLine = new StringBuilder();
        
        for (var outerIdx = 0; outerIdx < input.Length; outerIdx++)
        {
            var c = input[outerIdx];
            var possibleSubstitutions = _digits.Where(it => it.Key.StartsWith(c)).ToList();
            if (possibleSubstitutions.Count == 0)
            {
                processedLine.Append(c);
                continue;
            }

            var innerIdx = outerIdx;
            var currentSearch = new StringBuilder();
            
            while (possibleSubstitutions.Count >= 1 && innerIdx < input.Length)
            {
                var currentSearchChar = input[innerIdx];
                currentSearch.Append(currentSearchChar);
                possibleSubstitutions = possibleSubstitutions.Where(it => it.Key.StartsWith(currentSearch.ToString()))
                    .ToList();
                if (possibleSubstitutions.Count == 1 &&
                    possibleSubstitutions.First().Key.Equals(currentSearch.ToString()))
                {
                    processedLine.Append(possibleSubstitutions.First().Value);
                    outerIdx = innerIdx;
                    break;
                }
                
                if (possibleSubstitutions.Count == 0 || innerIdx == input.Length - 1)
                {
                    processedLine.Append(c);       
                }
                innerIdx++;
            }

        }
        
        return processedLine.ToString();
    }
}