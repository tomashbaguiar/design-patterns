using DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.Exercise;

namespace DesignPatterns.Tests.GammaCategorization.BehavioralPatterns.Iterator;

public class ExerciseTest
{
    [Fact]
    public void Test()
    {
        const int rootValue = 1;
        const int leftValue = 2;
        const int rightValue = 3;
        const int grandChildValue = 4;
        var correctOrder = new[] { rootValue, leftValue, grandChildValue, rightValue };
        var grandChild = new Node<int>(grandChildValue);
        var left = new Node<int>(leftValue, grandChild, null);
        var right = new Node<int>(rightValue);
        var root = new Node<int>(rootValue, left, right);

        var result = root.PreOrder.ToArray();
        
        Assert.Equal(correctOrder, result);
    }
}