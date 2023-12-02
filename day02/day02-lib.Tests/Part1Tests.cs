using AoC2023_lib;
using day02_lib;

namespace day02_lib.Tests;

public class Part1Tests
{
    
    [Theory]
    [InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 1, 3, 5, 9, 4)]
    [InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 2, 3, 1, 6, 6)]
    [InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 3, 3, 25, 11, 26)]
    [InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 4, 3, 23, 21, 7)]
    [InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 5, 2, 7, 3, 5)]
    public void ParseGameFromLine_ShouldReturnCorrectGameData(string input, int expectedGameId, int expectedGameSets, int expectedSumRed, int expectedSumBlue, int expectedSumGreen)
    {
        var actualGame = Part1.ParseGameFromLine(input);
        actualGame.Id.Should().Be(expectedGameId);
        actualGame.GameSets.Should().HaveCount(expectedGameSets);
        actualGame.GameSets.Sum(it => it.Red).Should().Be(expectedSumRed);
        actualGame.GameSets.Sum(it => it.Blue).Should().Be(expectedSumBlue);
        actualGame.GameSets.Sum(it => it.Green).Should().Be(expectedSumGreen);
    }

    [Theory]
    [InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", true)]
    [InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", true)]
    [InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", false)]
    [InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", false)]
    [InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", true)]
    public void IsGamePossible_ShouldReturnCorrectValue(string input, bool expectedPossible)
    {
        const int maxRed = 12;
        const int maxGreen = 13;
        const int maxBlue = 14;
        
        var game = Part1.ParseGameFromLine(input);
        var actualPossible = Part1.IsGamePossible(game, maxRed, maxGreen, maxBlue);
        actualPossible.Should().Be(expectedPossible);
    }
}