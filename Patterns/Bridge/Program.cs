class Program
{
    interface IImplementor
    {
        void OperationImplementation();
    }
    class ConcreteImplementatorA : IImplementor
    {
        public void OperationImplementation()
        {
            Console.WriteLine("Конкретная реализация А");
        }
    }
    class ConcreteImplementatorB : IImplementor
    {
        public void OperationImplementation()
        {
            Console.WriteLine("Конкретная реализация B");
        }
    }

    abstract class Abstraction
    {
        protected IImplementor implementor;
        public Abstraction(IImplementor implementor)
        {
            this.implementor = implementor;
        }
        public abstract void Operation();
    }

    class ConcreteAbstractionA : Abstraction
    {
        public ConcreteAbstractionA(IImplementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("Конкретная абстракция А");
            implementor.OperationImplementation();
        }
    }


    class ConcreteAbstractionB : Abstraction
    {
        public ConcreteAbstractionB(IImplementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("Конкретная абстракция B");
            implementor.OperationImplementation();
        }
    }
    public static void Main(string[] args)
    {
        Abstraction a = new ConcreteAbstractionA(new ConcreteImplementatorB());
        Abstraction b = new ConcreteAbstractionB(new ConcreteImplementatorA());
        a.Operation();  
        b.Operation();
    }
}