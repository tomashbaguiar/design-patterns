namespace DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.GenericValue;

public static class Dimension
{
    public class Two : IInteger
    {
        public int Value => 2;   
    }

    public class Three : IInteger
    {
        public int Value => 3;
    }
}