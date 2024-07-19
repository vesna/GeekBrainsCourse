class LegacyLibrary
{
    public void SpecificRequest()
    {
        Console.WriteLine("я стар, но все ще нужен!");
    }
}

interface ITarget
{
    void Request();
}

class Adapter : ITarget
{
    private LegacyLibrary _library;
    public Adapter(LegacyLibrary library)
    {
        _library = library;
    }
    public void Request()
    {
        _library.SpecificRequest();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        LegacyLibrary library = new LegacyLibrary();

        ITarget target = new Adapter(library);
        target.Request();
    }
}