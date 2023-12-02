using System.Diagnostics.CodeAnalysis;

namespace AoC2023_lib;

public readonly struct Option<T> where T : notnull
{
    public static Option<T> None => default;
    public static Option<T> Some(T value) => new(value);

    private readonly bool _isSome;
    private readonly T _value;

    private Option(T value)
    {
        _value = value;
        _isSome = _value is { };
    }

    public bool IsSome([MaybeNullWhen(false)]out T value)
    {
        value = _value;
        return _isSome;
    }

    public bool IsNone()
    {
        return !_isSome;
    }
}