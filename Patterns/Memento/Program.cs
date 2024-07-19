public class Memento
{
    public string State { get; private set; }
    public Memento(string state)
    {
        State = state;
    }
}

class Originator
{
    private string _state;
    public string State
    {
        get { return _state; }
        set { 
            _state = value;
            Console.WriteLine($"Состояние установлено {_state}");
        }
    }
    public Memento CreateMemento()
    {
        return new Memento( State );
    }
    public void RestoreMemento( Memento memento )
    {
        State= memento.State;
    }
}
public class Caretaker
{
    public Memento Memento { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        Originator originator = new Originator();
        originator.State = "состояние 1";

        Caretaker caretaker = new Caretaker();
        caretaker.Memento = originator.CreateMemento();

        originator.State = "состояние 2";

        Console.WriteLine($"Текущее состояние: {originator.State}");
        originator.RestoreMemento( caretaker.Memento );
        Console.WriteLine($"Восстановленное состояние: {originator.State}");
    }
}
