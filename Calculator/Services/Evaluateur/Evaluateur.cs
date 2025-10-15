namespace Calculator.Services.Evaluateur;
using Calculator.Services.MathUtils;
using Calculator.Services.Token;
using Calculator.Services.Node;

/// <summary>
/// Définit l'évaluation d'un noeud
/// </summary>
public class Evaluateur
{
    public int Evaluate(Node node)=>
        node switch
        {
            NumberNode n => n.Value,
            BinaryNode(var Left, TokenType.Plus, Node Right) => Services.MathUtils.MathUtils.Add(Evaluate(Left),
                Evaluate(Right)),
            BinaryNode(var Left, TokenType.Minus, Node Right) => Services.MathUtils.MathUtils.Substract(Evaluate(Left),
                Evaluate(Right)),
            BinaryNode(var Left, TokenType.Multiply, Node Right) => Services.MathUtils.MathUtils.Multiply(
                Evaluate(Right), Evaluate(Left)),
            BinaryNode(var Left, TokenType.Divide, Node Right) => Services.MathUtils.MathUtils.Divide(Evaluate(Right),
                Evaluate(Left)),
            _ => throw new InvalidOperationException($"Noeud non supporté : {node}")
        };
    
}