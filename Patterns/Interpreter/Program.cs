using System.Linq.Expressions;

abstract class Experssion
{
    public abstract bool Interpret(string context);
}

class TermenalExpression : Experssion
{
    private string data;
    public TermenalExpression(string data)
    {
        this.data = data;
    }

    public override bool Interpret(string context)
    {
        return context.Contains(data);
    }
}
class AndExpression : Experssion
{
    private Experssion expr1;
    private Experssion expr2;
    public AndExpression(Experssion expr1, Experssion expr2)
    {
        this.expr1 = expr1;
        this.expr2 = expr2;
    }

    public override bool Interpret(string context)
    {
        return expr1.Interpret(context) && expr2.Interpret(context);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        //Expression person = new TermenalExpression("Миша");
        //Expression married = new TermenalExpression("Женат");
        //Expression isMarried = new AndExpression(person, married);

        //Console.WriteLine("Миша женат?: " + isMarried.Interpret("Миша женат!"));
        //Console.WriteLine("Миша женат?: " + isMarried.Interpret("Миша разведен?"));
    }
}
