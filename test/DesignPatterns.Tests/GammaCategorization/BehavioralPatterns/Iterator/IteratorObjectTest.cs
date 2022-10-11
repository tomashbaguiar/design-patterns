using DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.ObjectIterator;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Iterator;

public class IteratorObjectTest
{
    [Fact]
    public void Test()
    {
        var left = new Node<int>(2);
        var right = new Node<int>(3);
        var root = new Node<int>(1, left, right);
        var it = new InOrderIterator<int>(root);
        var correctOrder = new[] { 2, 1, 3 };

        var i = 0;
        while (it.MoveNext())
        {
            Assert.Equal(correctOrder[i++], it.Current.Value);
        }
    }
}