namespace Calculator.Services.AnalyseurSyntaxique;
using Calculator.Services.Token;
using Calculator.Services.Node;

/// <summary>
/// Définit l'analyseur syntaxique d'une expression arithmétique
/// On définit la grammaire comme suit :
/// E -> T + T | T - T | T
/// T -> F * F | F / F | F
/// F -> Nombre | ( E )
/// Avec E une expression, T un terme et F un facteur
/// </summary>
public class AnalyseurSyntaxique
{
    private readonly List<Token> tokens;
    private int curseur;

    public AnalyseurSyntaxique(List<Token> tokens)
    {
        this.tokens = tokens;
        this.curseur = 0; // Initialisation explicite
    }

    private Token? TokenActuel => curseur < tokens.Count ? tokens[curseur] : null;

    private Token UtiliserToken(TokenType type)
    {
        if (TokenActuel == null)
        {
            throw new Exception($"Fin de l'expression atteinte, attendu : {type}");
        }
        
        if (TokenActuel.Type != type)
        {
            throw new Exception($"Token non attendu : {TokenActuel.Type} (valeur: {TokenActuel.Value}), attendu : {type}");
        }
        
        var token = TokenActuel;
        curseur++;
        return token;
    }

    /// <summary>
    /// Définit la première règle de dérivation
    /// E -> T ((+|-) T)*
    /// </summary>
    public Node AnalyseExpression() 
    {
        Node node = AnalyseTerme();

        while (TokenActuel != null && (TokenActuel.Type == TokenType.Plus || TokenActuel.Type == TokenType.Minus))
        {
            var operateur = TokenActuel.Type; // CORRECTION: stocker le Type, pas le Token
            UtiliserToken(operateur);
            var right = AnalyseTerme();
            node = new BinaryNode(node, operateur, right);
        }
        
        return node;
    }

    /// <summary>
    /// Définit la deuxième règle de dérivation
    /// T -> F ((*|/) F)*
    /// </summary>
    private Node AnalyseTerme()
    {
        Node node = AnalyseFacteur();

        while (TokenActuel != null && (TokenActuel.Type == TokenType.Multiply || TokenActuel.Type == TokenType.Divide))
        {
            var operateur = TokenActuel.Type; // CORRECTION: stocker le Type, pas le Token
            UtiliserToken(operateur);
            var right = AnalyseFacteur();
            node = new BinaryNode(node, operateur, right);
        }
        
        return node;
    }

    /// <summary>
    /// Lit un nombre ou fait appel à AnalyseExpression s'il y a une sous-expression parenthésée
    /// F -> Nombre | ( E )
    /// </summary>
    private Node AnalyseFacteur()
    {
        if (TokenActuel == null)
            throw new Exception("Expression incomplète");

        if (TokenActuel.Type == TokenType.Number)
        {
            int value = int.Parse(TokenActuel!.Value!);
            UtiliserToken(TokenType.Number);
            return new NumberNode(value);
        }
        else if (TokenActuel.Type == TokenType.LeftParen)
        {
            UtiliserToken(TokenType.LeftParen);
            var node = AnalyseExpression();
            
            if (TokenActuel == null || TokenActuel.Type != TokenType.RightParen)
                throw new Exception("Parenthèse fermante manquante");
                
            UtiliserToken(TokenType.RightParen);
            return node;
        }
        else
        {
            throw new Exception($"Token inattendu : {TokenActuel.Type} (valeur: {TokenActuel.Value})");
        }
    }

    public bool EstBienParenthese(List<Token> tokens)
    {
        Stack<int> pile = new Stack<int>();
        
        foreach(Token token in tokens)
        {
            if (token.Type == TokenType.LeftParen)
            {
                pile.Push(1);
            }
            else if (token.Type == TokenType.RightParen)
            {
                if(pile.Count == 0) 
                    return false;
                pile.Pop();
            }
        }
        
        return pile.Count == 0;
    }
}