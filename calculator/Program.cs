
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Evaluate(args[0]));
    }

    public static double Evaluate(string expression)
    {
        if (double.TryParse(expression, out var value))
        {
            return value;
        }

        if (expression.IndexOf('+') == -1)
        {
            var subtractionParts = expression.Split('-');
            var subtractionResult = 0d;
            for (var i = 0; i < subtractionParts.Length; i++)
            {
                if (i == 0)
                {
                    subtractionResult = Evaluate(subtractionParts[i]);
                }
                else
                {
                    subtractionResult -= Evaluate(subtractionParts[i]);
                }
            }
            return subtractionResult;
        }
        else
        {
            var additionParts = expression.Split('+');
            var additionResult = 0d;
            foreach (var partToAdd in additionParts)
            {
                additionResult += Evaluate(partToAdd);
            }
            return additionResult;
        }

        return 0d;
    }
}