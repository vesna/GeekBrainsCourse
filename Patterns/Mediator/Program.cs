abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}
class ConcreteMediator : Mediator
{
    private List<Colleague> colleagues = new List<Colleague>();
    public void AddColleague(Colleague colleague)
    {
        colleagues.Add(colleague);
    }

    public override void Send(string message, Colleague colleague)
    {
        foreach(Colleague col in colleagues)
        {
            if(col != colleague)
            {
                col.Recieve(message);
            }
        }
    }
}

abstract class Colleague
{
    protected Mediator mediator;
    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
    public abstract void Send(string message);
    public abstract void Recieve(string message);
}

class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1 (Mediator mediator) : base(mediator) { }
    public override void Recieve(string message)
    {
        Console.WriteLine($"ConcreteColleague1 получил: {message}");
    }

    public override void Send(string message)
    {
        mediator.Send(message, this);
    }
}
class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator) : base(mediator) { }
    public override void Recieve(string message)
    {
        Console.WriteLine($"ConcreteColleague2 получил: {message}");
    }

    public override void Send(string message)
    {
        mediator.Send(message, this);
    }
}
class Proram
{
    public static void Main(string[] args)
    {
        ConcreteMediator mediator = new ConcreteMediator();
        Colleague colleague1 = new ConcreteColleague1(mediator);
        Colleague colleague2 = new ConcreteColleague2(mediator);

        mediator.AddColleague(colleague1);
        mediator.AddColleague(colleague2);

        colleague1.Send("Привет от коллеги 1");
        colleague2.Send("Привет от коллеги 2");
    }
}