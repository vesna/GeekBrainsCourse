interface ISubject
{
    void Request();
}

class RealClass : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealClass отробатывает запрос");
    }
}
class Proxy : ISubject
{
    private RealClass realsubject;
    public Proxy()
    {
        realsubject = new RealClass();
    }
    public void Request()
    {
        Console.WriteLine("Proxy получает запрос");
        realsubject.Request();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Proxy proxy = new Proxy();
        proxy.Request();
    }
}
