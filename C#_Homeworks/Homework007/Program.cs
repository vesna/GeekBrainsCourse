using Homework007;
using System.Collections.Generic;

class Program
{
    /*Доработайте программу калькулятор реализовав выбор действий и вывод результатов на экран в цикле так 
     * чтобы калькулятор мог работать до тех пор пока пользователь не нажмет отмена или введёт пустую строку.*/
    static void Calculator_GotResult(object sender, EventArgs e)
    {
        Console.WriteLine($"{((Calculator)sender).Result}");
    }

    /*
        static int calcSum(List<int> list, Func<int,int,int> op)
        {
            int sum = 0;
            foreach (int item in list) { 
                sum = op(sum, item);
            }
            return sum;
        }*/

    public static bool CheckExitSymbol(string? v, out string input)
    {
        input = v;
        if (input == " ") { return true; }
        return false;
    }

    static void Main(string[] args)
    {
        // List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        //var res = calcSum(list, (x, y) => x + y);

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

            switch (sign)
            {
                case "+":
                    calc.Sum(b); break;
                case "-":
                    calc.Substruct(b); break;
                case "*":
                    calc.Multiply(b); break;
                case "/":
                    calc.Divide(b); break;
            }

           // Console.WriteLine(result);
        } 
    }
}
