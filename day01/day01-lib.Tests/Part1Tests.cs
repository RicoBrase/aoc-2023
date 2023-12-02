namespace day01_lib.Tests;

public class Part1Tests
{
    [Theory]
    [InlineData("1abc2", 12)]
    [InlineData("pqr3stu8vwx", 38)]
    [InlineData("a1b2c3d4e5f", 15)]
    [InlineData("treb7uchet", 77)]
    public void ProcessSingleLine_ShouldReturnCorrectValues(string input, int expectedOutput)
    {
        var actualOutput = Part1.ProcessSingleLine(input);
        actualOutput.Should().Be(expectedOutput);
    }
}