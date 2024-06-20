using Homework008;

class Program
{
    //Доработайте класс калькулятора способным работать как с целочисленными так и с дробными числами. (возможно стоит задействовать перегрузку операций).
    static void Calculator_GotResult(object sender, EventArgs e)
    {
        Console.WriteLine($"{((Calculator)sender).Result}");
    }

    public static bool CheckExitSymbol(string? v, out string input)
    {
        input = v;
        if (input == " ") { return true; }
        return false;
    }
    public static void Execute(Action<int> action, int b) {
        try
        {
            action.Invoke(b);
        }
        catch (CalculatorDivideByZeroException ex)
        {
            Console.WriteLine(ex);
        }
        catch (CalculateOperationCauseOverflowException ex)
        {
            Console.WriteLine(ex);
        }
    }
    static void Main(string[] args)
    {
        bool isExit = false;
        Console.WriteLine("Для выхода нажмите пробел");
        Console.WriteLine("Введите первое число:");
        isExit = CheckExitSymbol(Console.ReadLine(), out string res0);
        if (isExit) return;
        int.TryParse(res0, out int a);
        ICalc calc = new Calculator(a);
        calc.GotResult += Calculator_GotResult;

        while (!isExit)
        {
            Console.WriteLine("Введите еще число:");
            isExit = CheckExitSymbol(Console.ReadLine(), out string res1);
            if (isExit) return;
            int.TryParse(res1, out int b); ;

            bool isSign = false;
            string sign = "";
            do
            {
                Console.WriteLine("Введите знак (-,+,*,/):");
                isExit = CheckExitSymbol(Console.ReadLine(), out string res2);

                if (isExit) return;
                sign = res2;
                if ((new string[] { "+", "-", "/", "*" }).Contains<string>(sign))
                { isSign = true; }
                else
                {
                    isSign = false;
                    Console.WriteLine("Не верный знак");
                }
            } while (!isSign);
            try
            {
                switch (sign)
                {
                    case "+":
                        Execute(calc.Sum, b); break;
                    case "-":
                        Execute(calc.Substruct, b); break;
                    case "*":
                        Execute(calc.Multiply, b); break;
                    case "/":
                        Execute(calc.Divide, b); break;
                }
            }catch(CalculatorDivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch (CalculateOperationCauseOverflowException ex)
            {
                Console.WriteLine(ex);
            }

            // Console.WriteLine(result);
        }
    }
}
