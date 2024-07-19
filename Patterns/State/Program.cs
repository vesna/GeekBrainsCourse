using System.Runtime.CompilerServices;

class Context
{
    private IState state;
    public Context(IState initialState)
    {
        this.state = initialState;
    }
    public void SetState(IState newState)
    {
        state = newState;
    }
    public void Request()
    {
        state.Handle(this);
    }
}

interface IState
{
    void Handle(Context context);
}
class ConcreteStateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Обрабатываем запрос в состоянии А");
        context.SetState(new ConcreteStateB());
    }
}
class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Обрабатываем запрос в состоянии B");
        context.SetState(new ConcreteStateA());
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Context context = new Context(new ConcreteStateA());

        context.Request();
        context.Request();
        context.Request();
    }
}
