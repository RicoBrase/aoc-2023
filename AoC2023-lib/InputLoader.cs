namespace AoC2023_lib;

public class InputLoader
{
    
    public static string LoadFileAsString(string fileName)
    {
        return File.ReadAllText(fileName);
    }

    public static IEnumerable<string> LoadFileAsLines(string fileName)
    {
        return File.ReadAllLines(fileName);
    }
}