namespace day02_lib;

public static class Part2
{
    public static GameSet FindMinimumCubesForPossibleGame(Game game)
    {
        var red = game.GameSets.Max(it => it.Red);
        var green = game.GameSets.Max(it => it.Green);
        var blue = game.GameSets.Max(it => it.Blue);
        
        return new GameSet(red, green, blue);
    }

    public static int GetGameSetPower(GameSet gameSet)
    {
        return gameSet.Red * gameSet.Green * gameSet.Blue;
    }
}