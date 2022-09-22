namespace DesignPatterns.GammaCategorization.StructuralPatterns.Facade;

public static class Generator
{
    private static readonly Random Random = new();

    public static List<int> Generate(int count)
    {
        return Enumerable.Range(0, count)
            .Select(_ => Random.Next(1, 6))
            .ToList();
    }
}

public static class Splitter
{
    public static IEnumerable<List<int>> Split(List<List<int>> array)
    {
        var result = new List<List<int>>();

        var rowCount = array.Count;
        var colCount = array[0].Count;

        // get the rows
        for (var r = 0; r < rowCount; ++r)
        {
            var theRow = new List<int>();
            for (var c = 0; c < colCount; ++c)
                theRow.Add(array[r][c]);
            result.Add(theRow);
        }

        // get the columns
        for (var c = 0; c < colCount; ++c)
        {
            var theCol = new List<int>();
            for (var r = 0; r < rowCount; ++r)
                theCol.Add(array[r][c]);
            result.Add(theCol);
        }

        // now the diagonals
        var diag1 = new List<int>();
        var diag2 = new List<int>();
        for (var c = 0; c < colCount; ++c)
        {
            for (var r = 0; r < rowCount; ++r)
            {
                if (c == r)
                    diag1.Add(array[r][c]);
                var r2 = rowCount - r - 1;
                if (c == r2)
                    diag2.Add(array[r][c]);
            }
        }

        result.Add(diag1);
        result.Add(diag2);

        return result;
    }
}

public static class Verifier
{
    public static bool Verify(List<List<int>> array)
    {
        if (!array.Any()) return false;

        var expected = array.First().Sum();

        return array.All(t => t.Sum() == expected);
    }
}

public static class MagicSquareGenerator
{
    public static IList<List<int>> Generate(int size)
    {
        var generated = new List<List<int>>();
        do
        {
            generated.Clear();
            var newTry = new List<List<int>>();
            for (var i = 0; i < size; i++)
            {
                var generate = Generator.Generate(size);
                newTry.Add(generate);
            }

            var split = Splitter.Split(newTry);

            generated.AddRange(split);
        } while (!Verifier.Verify(generated));

        return generated;
    }
}