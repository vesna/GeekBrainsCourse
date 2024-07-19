class SubSystem1
{
    public void Operation1()
    {
        Console.WriteLine("Операция подсистемы 1");
    }
}
class SubSystem2
{
    public void Operation2()
    {
        Console.WriteLine("Операция подсистемы 2");
    }
}
class SubSystem3
{
    public void Operation3()
    {
        Console.WriteLine("Операция подсистемы 3");
    }
}
class Fasade
{
    private SubSystem1 _subSystem1;
    private SubSystem2 _subSystem2;
    private SubSystem3 _subSystem3;

    public Fasade()
    {
        _subSystem1 = new SubSystem1();
        _subSystem2 = new SubSystem2();
        _subSystem3 = new SubSystem3();
    }
    public void Operation()
    {
        Console.WriteLine("Операция фасада");
        _subSystem1.Operation1();
        _subSystem2.Operation2();
        _subSystem3.Operation3();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Fasade fasade = new Fasade();
        fasade.Operation();
    }
}
