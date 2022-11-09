
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static double Evaluate(string expression)
    {
        var parts = expression.Split('+');
        return double.Parse(parts[0]) + double.Parse(parts[1]);
    }
}