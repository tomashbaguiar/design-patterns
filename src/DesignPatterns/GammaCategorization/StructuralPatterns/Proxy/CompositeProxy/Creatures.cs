namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.CompositeProxy;

public class Creatures
{
    private readonly int _size;
    private byte[] _age;
    private Position[] _positions;

    public Creatures(int size)
    {
        _size = size;
        _age = new byte[size];
        _positions = new Position[size];
    }

    public IEnumerator<CreatureProxy> GetEnumerator()
    {
        for (var pos = 0; pos < _size; pos++)
        {
            yield return new CreatureProxy(this, pos);
        }
    }

    public struct CreatureProxy
    {
        private readonly Creatures _creatures;
        private readonly int _index;

        public CreatureProxy(Creatures creatures, int index)
        {
            _creatures = creatures;
            _index = index;
        }

        public ref byte Age => ref _creatures._age[_index];
        public ref Position Position => ref _creatures._positions[_index];
    }
}