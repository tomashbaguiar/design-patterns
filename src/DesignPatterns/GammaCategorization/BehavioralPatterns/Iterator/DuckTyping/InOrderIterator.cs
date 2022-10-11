using DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.ObjectIterator;

namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Iterator.DuckTyping;

public class InOrderIterator<T>
{
    private readonly Node<T> _root;
    public Node<T> Current { get; set; }
    private bool _yieldedStart;

    public InOrderIterator(Node<T> root)
    {
        _root = root;
        Current = root;
        while (Current.Left != null)
        {
            Current = Current.Left;
        }
    }

    public bool MoveNext()
    {
        if (!_yieldedStart)
        {
            _yieldedStart = true;
            return true;
        }

        if (Current.Right != null)
        {
            Current = Current.Right;
            while (Current.Left != null)
            {
                Current = Current.Left;
            }

            return true;
        }

        var p = Current.Parent;
        while (p != null && Current == p.Right)
        {
            Current = p;
            p = p.Parent;
        }

        Current = p;
        return Current != null;
    }

    public void Reset()
    {
        Current = _root;
        _yieldedStart = false;
    }
}