interface IComponent
{
    int Operation();
}

class Leaf : IComponent
{
    public int Operation()
    {
        return 1;
    }
}

class Composite : IComponent
{
    private List<IComponent> cildren = new List<IComponent>();
    public void Add(IComponent component)
    {
        cildren.Add(component);
    }
    public int Operation()
    {
        Console.WriteLine("Операция компоновщика");
        int i = 0;
        foreach (IComponent component in cildren)
        {
            i += component.Operation();
        }
        return i;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Composite composite = new Composite();
        IComponent leaf1 = new Leaf();
        composite.Add(leaf1);
        IComponent leaf2 = new Leaf();
        composite.Add(leaf2);

        IComponent component = composite;
        List<IComponent> l = new List<IComponent> { leaf1, leaf2, composite };
        l.ForEach(i => { Console.WriteLine(i.Operation()); });
    }
}
