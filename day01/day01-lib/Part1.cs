using AoC2023_lib;

namespace day01_lib;

public static class Part1
{
    public static int ProcessSingleLine(string input)
    {
        var firstDigit = Option<int>.None;
        var lastFoundDigit = Option<int>.None;

        foreach (var c in input)
        {
            if (!char.IsDigit(c)) continue;
            
            lastFoundDigit = Option<int>.Some(int.Parse(c.ToString()));

            if (firstDigit.IsNone())
            {
                firstDigit = lastFoundDigit;
            }
        }

        if (firstDigit.IsSome(out var first) && lastFoundDigit.IsSome(out var last))
        {
            return int.Parse($"{first}{last}");
        }

        throw new Exception("No digits in input!");
    }
}