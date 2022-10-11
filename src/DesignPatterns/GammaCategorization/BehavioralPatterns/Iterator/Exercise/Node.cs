namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.Exercise;

public class Node<T>
{
    public T Value;
    public Node<T>? Parent;
    public Node<T>? Left;
    public Node<T>? Right;

    public Node(T value, Node<T>? left = null, Node<T>? right = null)
    {
        Value = value;
        Left = left;
        Right = right;

        if (left != null)
        {
            left.Parent = this;
        }
        if (right != null)
        {
            right.Parent = this;
        }
    }

    public IEnumerable<T> PreOrder
    {
        get
        {
            IEnumerable<Node<T>> Traverse(Node<T> current)
            {
                yield return current;
                
                if (current.Left != null)
                {
                    foreach (var left in Traverse(current.Left))
                    {
                        yield return left;
                    }
                }

                if (current.Right != null)
                {
                    foreach (var right in Traverse(current.Right))
                    {
                        yield return right;
                    }
                }
            }

        
            foreach (var node in Traverse(this))
            {
                yield return node.Value;
            }
        }
    }
}