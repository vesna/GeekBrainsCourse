interface IStrategy
{
    void Execute();
}

class ConcreteStrategyA : IStrategy
{
    public void Execute() {
        Console.WriteLine("Выполняется стратегия А");
    }
}

class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Выполняется стратегия B");
    }
}

class ConcreteStrategyC : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Выполняется стратегия C");
    }
}

class Context
{
    private IStrategy strategy;

    public Context(IStrategy strategy)
    {
        this.strategy = strategy;
    }   

    public void SetStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        strategy.Execute();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Context context = new Context(new ConcreteStrategyA());
        context.ExecuteStrategy();

        context.SetStrategy(new ConcreteStrategyB());
        context.ExecuteStrategy();

        context = new Context(new ConcreteStrategyC());
        context.ExecuteStrategy();
    }
}