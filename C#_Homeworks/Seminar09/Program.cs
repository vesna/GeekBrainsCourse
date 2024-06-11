/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

// void Print(int number)
// {
//     Console.Write($" {number}");
//     if (number > 1) Print(number - 1);
// }

// Console.WriteLine("Введите переменную N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n >= 1) Print(n);
// else Console.WriteLine("Ошибка ввода");


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

// Console.WriteLine("Введите переменную m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n >= 1 && m >= 1)
// {
//     if (m > n) Console.WriteLine("M должна быть меньше или равно N");
//     int result = 0;
//     do
//     {
//         result += m;
//         m++;
//     } while (m <= n);
//     Console.Write($"Сумма натуральных элементов в промежутке от M до N: {result}");
// }
// else Console.WriteLine("Ошибка ввода");

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Ackerman(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = Ackerman(m, n - 1);
        m--;
    }
    return n + 1;
}

Console.WriteLine("Введите переменную m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 0 && m >= 0)
    Console.WriteLine($"A(m,n) = {Ackerman(m, n)}");
else
    Console.WriteLine("Ошибка ввода");