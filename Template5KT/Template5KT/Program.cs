namespace Template5KT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteStrategyA assault = new();
            ConcreteStrategyB sniper = new();
            Context context = new(assault);
            context.ExecuteAlgorithm();
            context.ContextStrategy = sniper;
            context.ExecuteAlgorithm();

        }
    }
}
