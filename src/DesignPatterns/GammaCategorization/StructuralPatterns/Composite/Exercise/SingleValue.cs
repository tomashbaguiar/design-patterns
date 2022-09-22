using System.Collections;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Exercise;

public class SingleValue : IValueContainer
{
    public int Value;
    public IEnumerator<int> GetEnumerator()
    {
        yield return Value;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}