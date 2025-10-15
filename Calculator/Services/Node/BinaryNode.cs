namespace Calculator.Services.Node;
using Calculator.Services.Token;

public record BinaryNode(Node Left, TokenType Type, Node Right): Node;