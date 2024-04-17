﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

// Console.Write("Введите первое число: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double b = Convert.ToDouble(Console.ReadLine());
// if (a > b) 
//     Console.WriteLine($"a = {a}; b = {b} -> max = {a}");
// else 
//     Console.WriteLine($"a = {a}; b = {b} -> max = {b}");

/*Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

// int size = 3;
// Console.WriteLine("Введите три числа");
// double [] Data = new double[size];
// int i = 0;
// while (i < size)
// {
//     Data[i] = Double.Parse(Console.ReadLine());
//     Console.WriteLine();
//     i++;
// }
// double max = Double.MinValue;
// for (i = 0; i < size; i = i + 1)
// {
//     if (Data[i] > max) max = Data[i];
// }
// Console.WriteLine($"max = {max}");  

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

// Console.Write("Введите число: ");
// double a = Convert.ToDouble(Console.ReadLine());
// if(a % 2 == 0) 
//     Console.WriteLine("Да");  
// else
//     Console.WriteLine("Нет");  

/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

// Console.Write("Введите целое число: ");
// int N;
// int i = 2;
// if(Int32.TryParse(Console.ReadLine(), out N))
// {
//     do
//     {
//         if(i <= N) Console.Write($"{i} ");
//         i = i + 2;
//     }while(i <= N);
// }
// else 
//     Console.WriteLine("Ошибка ввода");