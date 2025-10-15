namespace Calculator.Services.MathUtils;

public class MathUtils
{
    public static int Add(int a, int b)
    {
        return  a + b;
    }

    public static int Substract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Ty es un golmon tu divises par zero");
        }
        return a / b;
    }
}