
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static double Evaluate(string expression)
    {
        var parts = expression.Split('+');
        var result = 0d;
        foreach (var subExpression in parts)
        {
            result += double.Parse(subExpression);
        }
        return result;
    }
}