using Strategy;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassOne classOne = new();
        
        StrategyClass strategy = new(classOne);
        Console.WriteLine(strategy.ContextInterface());
        Console.ReadLine();
    }
}