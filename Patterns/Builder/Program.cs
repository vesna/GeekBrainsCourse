class Product
{
    public string Name { get; set; }
    public string Color { get; set; }
    public string Description { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Описание: {Description}");
    }
}

interface IBuilder
{
    void BuildName(string name);
    void BuildColor(string color);
    void BuildDescription(string description);
    Product Build();
}

class ConcreteBuilder : IBuilder
{
    private string name;
    private string color;
    private string description;

    public Product Build()
    {
        return new Product { Name = name, Color = color, Description = description};
    }

    public void BuildColor(string color)
    {
        this.color = color;
    }

    public void BuildDescription(string description)
    {
        this.description = description;
    }

    public void BuildName(string name)
    {
        this.name = name;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        IBuilder builder = new ConcreteBuilder();
        builder.BuildName("Карандаш");
        builder.BuildColor("Синий");  
        builder.BuildDescription("Твердый");    

        Product product = builder.Build();

        product.ShowInfo();
    }
}