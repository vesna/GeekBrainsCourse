interface IElement
{
    void Accept(IVisitor visitor);
}

class ConcreteElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }

    public void OperationA()
    {
        Console.WriteLine("ConcreteElementA операция А");
    }
}

class ConcreteElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }

    public void OperationB()
    {
        Console.WriteLine("ConcreteElementB операция B");
    }

}

interface IVisitor
{
    void VisitConcreteElementA(ConcreteElementA elementA);
    void VisitConcreteElementB(ConcreteElementB elementB);
}

class ConcreterVisitor : IVisitor
{
    public void VisitConcreteElementA(ConcreteElementA elementA)
    {
        Console.WriteLine("Посетитель посещает ConcreteElementA");
        elementA.OperationA();
    }

    public void VisitConcreteElementB(ConcreteElementB elementB)
    {
        Console.WriteLine("Посетитель посещает ConcreteElementB");
        elementB.OperationB();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        List<IElement> elements = new List<IElement>{
            new ConcreteElementA(),
            new ConcreteElementB()
        };

        ConcreterVisitor visitor = new ConcreterVisitor();

        foreach (IElement element in elements)
        {
            element.Accept(visitor);
        }
    }
}