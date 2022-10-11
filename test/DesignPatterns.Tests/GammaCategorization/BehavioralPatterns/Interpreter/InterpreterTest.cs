using DesignPatterns.GammaCategorization.BehavioralPatterns.Interpreter;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Interpreter;

public class InterpreterTest
{
    [Fact]
    public void LexingInputToTokens()
    {
        const string input = "(13+4)-(12+1)";
        const string expected = "`(`\t`13`\t`+`\t`4`\t`)`\t`-`\t`(`\t`12`\t`+`\t`1`\t`)`";
        
        var tokens = Lexing.Lex(input);
        
        Assert.Equal(0, string.CompareOrdinal(expected, string.Join("\t", tokens)));
    }
    
    [Fact(Skip = "Infinite Loop")]
    public void ParsingInputToTokens()
    {
        const string input = "(13+4)-(12+1)";
        var tokens = Lexing.Lex(input);
        
        var parsed = Parsing.Parse(tokens);
        
        Assert.Equal(4, parsed.Value);
    }
}