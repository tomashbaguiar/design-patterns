using DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.ObjectIterator;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.IteratorMethod;

public class BinaryTree<T>
{
    private Node<T> _root;

    public BinaryTree(Node<T> root)
    {
        _root = root;
    }

    public IEnumerable<Node<T>> InOrder
    {
        get
        {
            IEnumerable<Node<T>> Traverse(Node<T> current)
            {
                if (current.Left != null)
                {
                    foreach (var left in Traverse(current.Left))
                    {
                        yield return left;
                    }
                }

                yield return current;
                
                if (current.Right != null)
                {
                    foreach (var right in Traverse(current.Right))
                    {
                        yield return right;
                    }
                }
            }

            foreach (var node in Traverse(_root))
            {
                yield return node;
            }
        }
    }
}