namespace Calculator.Services.Calculatrice;
using Calculator.Services.AnalyseurSyntaxique;
using Calculator.Services.Evaluateur;
using Calculator.Services.Token;
using Calculator.Services.Node;
public class Calculatrice
{
    public int Calcul(string expression)
    {
        try
        {
            List<Token> tokens = Tokenizer.Tokenize(expression);
            AnalyseurSyntaxique analyseurSyntaxique = new AnalyseurSyntaxique(tokens);

            if (!analyseurSyntaxique.EstBienParenthese(tokens))
                throw new Exception("L'expression est mal parenthésée");

            Node node = analyseurSyntaxique.AnalyseExpression();
            Evaluateur evaluateur = new Evaluateur();
            int resultat = evaluateur.Evaluate(node);
            return resultat;   
        }
        catch (Exception ex)
        {
            // Affiche ou log l'erreur, utile pour le débogage
            Console.WriteLine("Erreur : " + ex.Message);
            throw;
        }
    }

}