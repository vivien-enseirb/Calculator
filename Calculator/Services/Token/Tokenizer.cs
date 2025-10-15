namespace Calculator.Services.Token;

/// <summary>
/// Définit la tokenisation
/// </summary>
public static class Tokenizer
{
    /// <summary>
    /// Permet de séparer une expression arithmétique en tokens
    /// </summary>
    /// <param name="text">Expression arithmétique sous forme de string</param>
    /// <returns>Une liste de tokens caractérisant l'expression arithmétique</returns>
    public static List<Token> Tokenize(string text)
    {
        var i = 0;
        var tokens = new List<Token>();
        
        while (i < text.Length)
        {
            char c = text[i];
            
            // Ignorer les espaces
            if (char.IsWhiteSpace(c))
            {
                i++;
                continue; // ⚠️ CRITIQUE : continue pour passer au prochain caractère
            }

            // Traiter les nombres
            if (char.IsDigit(c))
            {
                var number = "";
                while (i < text.Length && char.IsDigit(text[i]))
                {
                    number += text[i];
                    i++;
                }
                tokens.Add(new Token(TokenType.Number, number));
                continue; // ⚠️ CRITIQUE : continue après avoir traité le nombre
            }

            // Traiter les opérateurs et parenthèses
            Token token = c switch
            {
                '+' => new Token(TokenType.Plus),
                '-' => new Token(TokenType.Minus),
                '*' => new Token(TokenType.Multiply),
                '/' => new Token(TokenType.Divide),
                '(' => new Token(TokenType.LeftParen),
                ')' => new Token(TokenType.RightParen),
                _ => throw new Exception($"Caractère non reconnu : '{c}' à la position {i}")
            };
            
            tokens.Add(token);
            i++;
        }

        return tokens;
    }
}