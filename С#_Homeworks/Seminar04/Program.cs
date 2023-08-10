/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

// int A, B;
// Console.Write("Введите первое число: ");
// if(!Int32.TryParse(Console.ReadLine(), out A)) Console.WriteLine("Ошибка ввода");
// Console.Write("Введите второе число: ");
// if(!Int32.TryParse(Console.ReadLine(), out B)) Console.WriteLine("Ошибка ввода");
// Console.WriteLine(Math.Pow(A, B));

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

// int n;
// Console.Write("Введите число: ");
// if(!Int32.TryParse(Console.ReadLine(), out n)) Console.WriteLine("Ошибка ввода");
// int sum = 0;
// while (n != 0) {
//     sum += n % 10;
//     n /= 10;
// }
// Console.WriteLine(sum);

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int size = 8;
Console.WriteLine("Введите восемь чисел");
int[] Data = new int[size];
int i = 0;
int n;
while (i < size)
{
    if (Int32.TryParse(Console.ReadLine(), out n))
    {
        Data[i] = n;
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
        break;
    }
    i++;
}

Console.Write("[");
for (i = 0; i < size; i = i + 1)
{
    Console.Write($"{Data[i]}");
    if (i < size - 1) Console.Write(", ");
}
Console.Write("]");
