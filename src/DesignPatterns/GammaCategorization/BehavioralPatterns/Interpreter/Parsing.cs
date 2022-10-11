namespace DesignPatterns.GammaCategorization.BehavioralPatterns.Interpreter;

public static class Parsing
{
    public static IElement Parse(IReadOnlyList<Token> tokens)
    {
        var result = new BinaryOperation();
        var haveLhs = false;
        for (var i = 0; i < tokens.Count; i++)
        {
            var token = tokens[i];
            switch (token.MyType)
            {
                case Token.Type.Integer:
                    var integer = new Integer(int.Parse(token.Text));
                    if (!haveLhs)
                    {
                        result.Left = integer;
                        haveLhs = true;
                    }
                    else
                    {
                        result.Right = integer;
                    }
                    break;
                case Token.Type.Plus:
                    result.MyType = BinaryOperation.Type.Addition;
                    break;
                case Token.Type.Minus:
                    result.MyType = BinaryOperation.Type.Subtraction;
                    break;
                case Token.Type.LParen:
                    var j = i;
                    for (; j < tokens.Count; ++j)
                    {
                        if (tokens[j].MyType == Token.Type.RParen)
                        {
                            break;
                        }
                    }

                    var subExpression = tokens.Skip(i + 1).Take(j - i - 1).ToList();
                    var element = Parse(subExpression);
                    if (!haveLhs)
                    {
                        result.Left = element;
                        haveLhs = true;
                    }
                    else
                    {
                        result.Right = element;
                    }
                    i = j;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        return result;
    }
}