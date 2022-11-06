using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SmartTime.Core;

public readonly struct AuthToken: IEquatable<AuthToken>
{
    public readonly byte[] Token;
    public readonly string Prefix;

    /// <summary>
    /// Version of the token. This field is constant.
    /// </summary>
    public const int TokenVersion = 1;



    public AuthToken([NotNull] byte[] token, [MaybeNull] string? prefix)
    {
        if (token is not { Length: 4 }) throw new ArgumentException("Token invalid format.", nameof(token));
        //if (prefix == null) throw new ArgumentNullException(nameof(prefix));

        Token = token;
        Prefix = string.IsNullOrEmpty(prefix) ? "NONE" : prefix;
    }

    /// <summary>
    /// Gets token text.
    /// </summary>
    /// <returns>Token in format ST.vX.XXX-XXXXXX</returns>
    public override string ToString()
    {
        return $"ST.v{TokenVersion}.{Prefix}-{BitConverter.ToString(Token).Replace("-", string.Empty)}"
        ;
    }

    public static bool operator ==(AuthToken left, AuthToken right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(AuthToken left, AuthToken right)
    {
        return !left.Equals(right);
    }

    public override bool Equals(object? other)
    {
        if (other is AuthToken)
        {
            return Equals((AuthToken)other);
        }

        return false;
    }

    public bool Equals(AuthToken other)
    {
        return Token == other.Token && Prefix == other.Prefix;
    }

    public override int GetHashCode()
    {
        return Token.GetHashCode();
    }
}