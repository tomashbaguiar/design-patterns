using DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.DuckTyping;
using DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.ObjectIterator;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Iterator;

public class DuckTypingTest
{
    [Fact]
    public void Test()
    {
        const int rootValue = 1;
        const int leftValue = 2;
        const int rightValue = 3;
        var correctOrder = new[] { leftValue, rootValue, rightValue };
        var left = new Node<int>(leftValue);
        var right = new Node<int>(rightValue);
        var root = new Node<int>(rootValue, left, right);
        var tree = new BinaryTree<int>(root);

        var i = 0;
        foreach (var node in tree)
        {
            Assert.Equal(correctOrder[i++], node.Value);
        }
    }
}