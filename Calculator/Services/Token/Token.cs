namespace Calculator.Services.Token;

/// <summary>
/// Définit les différents type de token possible
/// </summary>
public enum TokenType
{
    Number,
    Plus,
    Minus,
    Multiply,
    Divide,
    LeftParen,
    RightParen
}

/// <summary>
/// Représente un token dans une expresion arithmétique
/// </summary>
public class Token
{
    public TokenType Type { get; set; }
    public string? Value { get; set; }

    public Token(TokenType type, string? value=null)
    {
        this.Type = type;
        this.Value = value;
    }
    
    public override string ToString()
    {
        return $"Token(Type : {Type}, Value : {Value})";
    }
}