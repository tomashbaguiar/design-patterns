namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.ObjectIterator;

public class Node<T>
{
    public T Value;
    public Node<T>? Left;
    public Node<T>? Right;
    public Node<T>? Parent;

    public Node(T value)
    {
        Value = value;
    }
    
    public Node(T value, Node<T> left, Node<T> right)
    {
        Value = value;
        Left = left;
        Right = right;
        Left.Parent = right.Parent = this;
    }
}