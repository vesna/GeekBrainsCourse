class Program
{
    abstract class Product
    {
        public abstract string GetName();
    }

    class ConcreteProductA : Product {
        public override string GetName() => "Conctete Product A";
    }
    class ConcreteProductB : Product
    {
        public override string GetName() => "Conctete Product B";
    }
    abstract class Creator
    {
        public abstract Product FactoryMethod();    
    }
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductA(); 
    }
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() => new ConcreteProductB();
    }
    public static void Main(string[] args)
    {
        Creator creatorA = new ConcreteCreatorA();
        Product productA = creatorA.FactoryMethod();

        Creator creatorB = new ConcreteCreatorB();
        Product productB = creatorB.FactoryMethod();

        Console.WriteLine(productA.GetName());
        Console.WriteLine(productB.GetName());
    }
}