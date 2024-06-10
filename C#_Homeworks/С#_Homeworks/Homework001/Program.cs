/*Урок 1. Начало работы: .Net и Visual Studio
Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.
*/

Console.WriteLine("Введите число:");
int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите число:");
int.TryParse(Console.ReadLine(), out int b); ;

Console.WriteLine("Введите знак (-,+,*,/):");
string? res = Console.ReadLine();
string sign = "";
if (res != null) sign = Convert.ToString(res);
 

if ((new string[] { "+", "-", "/", "*" }).Contains<string>(sign)){

} else {
    Console.WriteLine("Не верный знак");
}

int result = 0;
switch (sign) { 
    case "+":
        result = a + b; break;
    case "-":
        result = a - b; break;
    case "*":
        result = a * b; break;
    case "/":
        result = a / b; break;
    }

Console.WriteLine(result);



