using DesignPatterns.SolidPrinciples.SingleResponsibility.Correct;

namespace DesignPatterns.SolidPrinciples.SingleResponsibility;

public static class Persistence
{
    public static void SaveToFile(this Journal journal, string fileName, bool overWrite = false)
    {
        if (overWrite || !File.Exists(fileName))
            File.WriteAllText(fileName, journal.ToString());
    }
}