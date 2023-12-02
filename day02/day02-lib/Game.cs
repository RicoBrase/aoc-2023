namespace day02_lib;

public class Game(int id, IEnumerable<GameSet> gameSets)
{
    public int Id { get; private set; } = id;
    public IEnumerable<GameSet> GameSets { get; private set; } = gameSets;
}