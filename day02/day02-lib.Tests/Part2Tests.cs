namespace day02_lib.Tests;

public class Part2Tests
{
    private const string GAME1 = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";
    private const string GAME2 = "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue";
    private const string GAME3 = "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red";
    private const string GAME4 = "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red";
    private const string GAME5 = "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
    
    
    [Theory]
    [InlineData(GAME1, 4, 2, 6)]
    [InlineData(GAME2, 1, 3, 4)]
    [InlineData(GAME3, 20, 13, 6)]
    [InlineData(GAME4, 14, 3, 15)]
    [InlineData(GAME5, 6, 3, 2)]
    public void FindMinimumCubesForPossibleGame_ShouldReturnCorrectValues(string input, int expectedMinRed, int expectedMinGreen, int expectedMinBlue)
    {
        var game = Part1.ParseGameFromLine(input);
        var actualMinimumCubes = Part2.FindMinimumCubesForPossibleGame(game);
        actualMinimumCubes.Red.Should().Be(expectedMinRed);
        actualMinimumCubes.Green.Should().Be(expectedMinGreen);
        actualMinimumCubes.Blue.Should().Be(expectedMinBlue);
        Part1.IsGamePossible(game, actualMinimumCubes.Red, actualMinimumCubes.Green, actualMinimumCubes.Blue).Should()
            .BeTrue();
    }
    
    [Theory]
    [InlineData(GAME1, 48)]
    [InlineData(GAME2, 12)]
    [InlineData(GAME3, 1560)]
    [InlineData(GAME4, 630)]
    [InlineData(GAME5, 36)]
    public void GetGameSetPower_ShouldReturnCorrectValues(string input, int expectedPower)
    {
        var game = Part1.ParseGameFromLine(input);
        var minimumCubes = Part2.FindMinimumCubesForPossibleGame(game);
        var actualPower = Part2.GetGameSetPower(minimumCubes);

        actualPower.Should().Be(expectedPower);
    }
}