using Wrong = DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Wrong;
using Correct = DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Correct;
using Fluent = DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Fluent;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Builder;

public class HtmlBuilderTest
{
    [Fact]
    public void Test_Wrong()
    {
        var words = new[] { "Hello", "World" };
        const string expected = "<ul><li>Hello</li><li>World</li></ul>";
        
        var html = Wrong.HtmlBuilder.BuildHtmlString(words);

        Assert.Matches(expected, html);
    }
    
    [Fact]
    public void Test_Correct()
    {
        const string expected = "<ul>\n  <li>\n    Hello\n  </li>\n  <li>\n    World\n  </li>\n</ul>";

        var htmlBuilder = new Correct.HtmlBuilder("ul");
        htmlBuilder.AddChild("li", "Hello");
        htmlBuilder.AddChild("li", "World");

        var html = htmlBuilder.ToString();

        Assert.Matches(expected, html);
    }
    
    [Fact]
    public void Test_Fluent()
    {
        const string expected = "<ul>\n  <li>\n    Hello\n  </li>\n  <li>\n    World\n  </li>\n</ul>";

        var htmlBuilder = new Fluent.HtmlBuilder("ul")
            .AddChild("li", "Hello")
            .AddChild("li", "World");

        var html = htmlBuilder.ToString();

        Assert.Matches(expected, html);
    }
}