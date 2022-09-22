using DesignPatterns.SolidPrinciples.SingleResponsibility;
using Wrong = DesignPatterns.SolidPrinciples.SingleResponsibility.Wrong;
using Correct = DesignPatterns.SolidPrinciples.SingleResponsibility.Correct;

namespace DesignPatterns.Tests.SolidPrinciples.SingleResponsibility;

public class JournalTest
{
    [Fact]
    public void Test_Wrong()
    {
        const string firstEntry = "I cried today";
        const string secondEntry = "I ate a bug";
        var journal = new Wrong.Journal();
        journal.AddEntry(firstEntry);
        journal.AddEntry(secondEntry);

        journal.Save(string.Empty);
    }
    
    [Fact]
    public void Test_Correct()
    {
        const string firstEntry = "I cried today";
        const string secondEntry = "I ate a bug";
        var journal = new Correct.Journal();
        journal.AddEntry(firstEntry);
        journal.AddEntry(secondEntry);

        journal.SaveToFile(string.Empty);
    }
}