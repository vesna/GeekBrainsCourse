interface IFlyweight
{
    void Operation(string extrinsicState);
}
class ConcreteFlyweight : IFlyweight
{
    private string _intrinsicState;
    public ConcreteFlyweight(string intrinsicState)
    {
        _intrinsicState = intrinsicState;
    }
    public void Operation(string extrinsicState)
    {
        Console.WriteLine($"Приспособленец: внутреннее состояние = {_intrinsicState}, внешнее состояние = {extrinsicState}");
    }
}
class FlyweghtFactory
{
    private Dictionary<string, IFlyweight> _flyweghts = new Dictionary<string, IFlyweight> ();
    public IFlyweight GetFlyweigth(string key)
    {
        if(!_flyweghts.ContainsKey(key))
        {
            _flyweghts[key] = new ConcreteFlyweight (key);
        }
        return _flyweghts[key];
    }

}
class Program
{
    public static void Main(string[] args)
    {
        FlyweghtFactory factory = new FlyweghtFactory ();
        IFlyweight flyweight1 = factory.GetFlyweigth("SharedStateA");
        IFlyweight flyweight2 = factory.GetFlyweigth("SharedStateB");
        IFlyweight flyweight3 = factory.GetFlyweigth("SharedStateA");

        flyweight1.Operation("Внешнее состояние 1");
        flyweight2.Operation("Внешнее состояние 2");
        flyweight3.Operation("Внешнее состояние 3");
    }
}
