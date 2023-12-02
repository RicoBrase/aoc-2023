namespace day01_lib.Tests;

public class Part2Tests
{
    [Theory]
    [InlineData("eighthree", "83", 83)]
    [InlineData("two1nine", "219", 29)]
    [InlineData("eightwothree", "823", 83)]
    [InlineData("abcone2threexyz", "abc123xyz", 13)]
    [InlineData("xtwone3four", "x2134", 24)]
    [InlineData("4nineeightseven2", "49872", 42)]
    [InlineData("zoneight234", "z18234", 14)]
    [InlineData("7pqrstsixteen", "7pqrst6teen", 76)]
    public void PreprocessLine_ShouldReturnCorrectOutput(string input, string expectedTransformation, int expectedOutput)
    {
        var transformedInput = Part2.PreprocessLine(input);
        transformedInput.Should().Be(expectedTransformation);
        var actualOutput = Part1.ProcessSingleLine(transformedInput);
        actualOutput.Should().Be(expectedOutput);
    }
    
    
}