using AoC2023_lib;

namespace day02_lib;

public static class Part1
{
    public static Game ParseGameFromLine(string input)
    {
        // Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
        var lineSplit = input.Split(": ");
        // Game 1
        var rawGameData = lineSplit[0];
        // 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
        var rawGameSetData = lineSplit[1];

        // 1
        var gameId = int.Parse(lineSplit[0].Split(" ")[1]);
        var gameSets = rawGameSetData
            .Split("; ")
            // 3 blue, 4 red
            .Select(it =>
            {
                var rawGameSet = it
                    .Split(", ")
                    .Select(parts => parts.Split(" "))
                    .ToArray();

                var gsRed = rawGameSet.Where(x => x.Last().Equals("red")).Select(x => x.First()).FirstOrDefault("0");
                var gsBlue = rawGameSet.Where(x => x.Last().Equals("blue")).Select(x => x.First()).FirstOrDefault("0");
                var gsGreen = rawGameSet.Where(x => x.Last().Equals("green")).Select(x => x.First()).FirstOrDefault("0");

                var gsRedInt = int.Parse(gsRed);
                var gsGreenInt = int.Parse(gsGreen);
                var gsBlueInt = int.Parse(gsBlue);
                
                return new GameSet(gsRedInt, gsGreenInt, gsBlueInt);
            });

        return new Game(gameId, gameSets);
    }

    public static bool IsGamePossible(Game game, int maxRed, int maxGreen, int maxBlue)
    {
        return game.GameSets.All(gs => gs.Red <= maxRed)
            && game.GameSets.All(gs => gs.Green <= maxGreen)
            && game.GameSets.All(gs => gs.Blue <= maxBlue);
    }
}