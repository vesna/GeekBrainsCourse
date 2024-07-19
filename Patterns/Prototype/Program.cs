class Program
{
    class Prototype : ICloneable
    {
        public string Name { get; set; }
        public List<string> MoreNames { get; set; } = new List<string>();

        public Prototype(string name)
        {
            Name = name;
        }
        public Prototype Clone1()
        {
            var p = new Prototype(Name);
            p.MoreNames = new List<string>(MoreNames);
            return p;
        }

        public void Print()
        {
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Names: ");
            MoreNames.ForEach(x => Console.WriteLine(x));
        }

        public object Clone()
        {
            return Clone1();
        }
    }
    public static void Main(string[] args)
    {
        Prototype original = new Prototype("Оригинальный объект") { MoreNames = { "Еще одно имя" } };
        Prototype? clone = (Prototype)original.Clone();
       // clone.MoreNames.Clear();
        // Console.WriteLine("Имя которое мы добавили в инициализации = " + original.MoreNames[0]);
        clone?.Print();
    }
}
