using System.Runtime.Serialization;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.AdapterDecorator;

public class MyStringBuilder
{
    private readonly System.Text.StringBuilder _builder = new();

    public static implicit operator MyStringBuilder(string s)
    {
        var msb = new MyStringBuilder();
        msb._builder.Append(s);
        return msb;
    }

    public static MyStringBuilder operator +(MyStringBuilder myStringBuilder, string s)
    {
        myStringBuilder.Append(s);
        return myStringBuilder;
    }

    public override string ToString()
    {
        return _builder.ToString();
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        ((ISerializable)_builder).GetObjectData(info, context);
    }

    public System.Text.StringBuilder Append(bool value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(byte value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(char value)
    {
        return _builder.Append(value);
    }

    public unsafe System.Text.StringBuilder Append(char* value, int valueCount)
    {
        return _builder.Append(value, valueCount);
    }

    public System.Text.StringBuilder Append(char value, int repeatCount)
    {
        return _builder.Append(value, repeatCount);
    }

    public System.Text.StringBuilder Append(char[]? value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(char[]? value, int startIndex, int charCount)
    {
        return _builder.Append(value, startIndex, charCount);
    }

    public System.Text.StringBuilder Append(decimal value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(double value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(short value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(int value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(long value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(object? value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(ReadOnlyMemory<char> value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(ReadOnlySpan<char> value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(sbyte value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(float value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(string? value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(string? value, int startIndex, int count)
    {
        return _builder.Append(value, startIndex, count);
    }

    public System.Text.StringBuilder Append(System.Text.StringBuilder? value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(System.Text.StringBuilder? value, int startIndex, int count)
    {
        return _builder.Append(value, startIndex, count);
    }

    public System.Text.StringBuilder Append(ushort value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(uint value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(ulong value)
    {
        return _builder.Append(value);
    }

    public System.Text.StringBuilder Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
    {
        return _builder.Append(ref handler);
    }

    public System.Text.StringBuilder Append(IFormatProvider? provider, ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
    {
        return _builder.Append(provider, ref handler);
    }

    public System.Text.StringBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0)
    {
        return _builder.AppendFormat(provider, format, arg0);
    }

    public System.Text.StringBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1)
    {
        return _builder.AppendFormat(provider, format, arg0, arg1);
    }

    public System.Text.StringBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1, object? arg2)
    {
        return _builder.AppendFormat(provider, format, arg0, arg1, arg2);
    }

    public System.Text.StringBuilder AppendFormat(IFormatProvider? provider, string format, params object?[] args)
    {
        return _builder.AppendFormat(provider, format, args);
    }

    public System.Text.StringBuilder AppendFormat(string format, object? arg0)
    {
        return _builder.AppendFormat(format, arg0);
    }

    public System.Text.StringBuilder AppendFormat(string format, object? arg0, object? arg1)
    {
        return _builder.AppendFormat(format, arg0, arg1);
    }

    public System.Text.StringBuilder AppendFormat(string format, object? arg0, object? arg1, object? arg2)
    {
        return _builder.AppendFormat(format, arg0, arg1, arg2);
    }

    public System.Text.StringBuilder AppendFormat(string format, params object?[] args)
    {
        return _builder.AppendFormat(format, args);
    }

    public System.Text.StringBuilder AppendJoin(char separator, params object?[] values)
    {
        return _builder.AppendJoin(separator, values);
    }

    public System.Text.StringBuilder AppendJoin(char separator, params string?[] values)
    {
        return _builder.AppendJoin(separator, values);
    }

    public System.Text.StringBuilder AppendJoin(string? separator, params object?[] values)
    {
        return _builder.AppendJoin(separator, values);
    }

    public System.Text.StringBuilder AppendJoin(string? separator, params string?[] values)
    {
        return _builder.AppendJoin(separator, values);
    }

    public System.Text.StringBuilder AppendJoin<T>(char separator, IEnumerable<T> values)
    {
        return _builder.AppendJoin(separator, values);
    }

    public System.Text.StringBuilder AppendJoin<T>(string? separator, IEnumerable<T> values)
    {
        return _builder.AppendJoin(separator, values);
    }

    public System.Text.StringBuilder AppendLine()
    {
        return _builder.AppendLine();
    }

    public System.Text.StringBuilder AppendLine(string? value)
    {
        return _builder.AppendLine(value);
    }

    public System.Text.StringBuilder AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
    {
        return _builder.AppendLine(ref handler);
    }

    public System.Text.StringBuilder AppendLine(IFormatProvider? provider, ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
    {
        return _builder.AppendLine(provider, ref handler);
    }

    public System.Text.StringBuilder Clear()
    {
        return _builder.Clear();
    }

    public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
    {
        _builder.CopyTo(sourceIndex, destination, destinationIndex, count);
    }

    public void CopyTo(int sourceIndex, Span<char> destination, int count)
    {
        _builder.CopyTo(sourceIndex, destination, count);
    }

    public int EnsureCapacity(int capacity)
    {
        return _builder.EnsureCapacity(capacity);
    }

    public bool Equals(ReadOnlySpan<char> span)
    {
        return _builder.Equals(span);
    }

    public bool Equals(System.Text.StringBuilder? sb)
    {
        return _builder.Equals(sb);
    }

    public System.Text.StringBuilder.ChunkEnumerator GetChunks()
    {
        return _builder.GetChunks();
    }

    public System.Text.StringBuilder Insert(int index, bool value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, byte value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, char value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, char[]? value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, char[]? value, int startIndex, int charCount)
    {
        return _builder.Insert(index, value, startIndex, charCount);
    }

    public System.Text.StringBuilder Insert(int index, decimal value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, double value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, short value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, int value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, long value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, object? value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, ReadOnlySpan<char> value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, sbyte value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, float value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, string? value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, string? value, int count)
    {
        return _builder.Insert(index, value, count);
    }

    public System.Text.StringBuilder Insert(int index, ushort value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, uint value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Insert(int index, ulong value)
    {
        return _builder.Insert(index, value);
    }

    public System.Text.StringBuilder Remove(int startIndex, int length)
    {
        return _builder.Remove(startIndex, length);
    }

    public System.Text.StringBuilder Replace(char oldChar, char newChar)
    {
        return _builder.Replace(oldChar, newChar);
    }

    public System.Text.StringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
    {
        return _builder.Replace(oldChar, newChar, startIndex, count);
    }

    public System.Text.StringBuilder Replace(string oldValue, string? newValue)
    {
        return _builder.Replace(oldValue, newValue);
    }

    public System.Text.StringBuilder Replace(string oldValue, string? newValue, int startIndex, int count)
    {
        return _builder.Replace(oldValue, newValue, startIndex, count);
    }

    public string ToString(int startIndex, int length)
    {
        return _builder.ToString(startIndex, length);
    }

    public int Capacity
    {
        get => _builder.Capacity;
        set => _builder.Capacity = value;
    }

    public char this[int index]
    {
        get => _builder[index];
        set => _builder[index] = value;
    }

    public int Length
    {
        get => _builder.Length;
        set => _builder.Length = value;
    }

    public int MaxCapacity => _builder.MaxCapacity;
}