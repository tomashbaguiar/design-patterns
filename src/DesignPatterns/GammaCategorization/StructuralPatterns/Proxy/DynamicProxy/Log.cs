using System.Dynamic;
using System.Text;
using ImpromptuInterface;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.DynamicProxy;

public class Log<T> : DynamicObject where T : class, new()
{
    private readonly Dictionary<string, int> _methodCallCount = new();
    private readonly T _subject;

    public Log(T subject)
    {
        _subject = subject;
    }
    
    public static I As<I>() where I : class
    {
        if (!typeof(I).IsInterface)
            throw new ArgumentException("I must be an interface type!");

        return new Log<T>(new T()).ActLike<I>();
    }

    public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
    {
        try
        {
            Console.WriteLine($"Invoking {_subject.GetType().Name}.{binder.Name} with arguments " +
                               $"[{string.Join(",", args!)}]");
            
            if (_methodCallCount.ContainsKey(binder.Name)) _methodCallCount[binder.Name]++;
            else _methodCallCount.Add(binder.Name, 1);

            result = _subject.GetType().GetMethod(binder.Name)?.Invoke(_subject, args);
            return true;
        }
        catch
        {
            result = null;
            return false;
        }
    }

    public string Info
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var (key, value) in _methodCallCount)
                sb.AppendLine($"{key} called {value} time(s)");
            return sb.ToString();
        }
    }

    public override string ToString()
    {
        return $"{Info}\n{_subject}";
    }
}