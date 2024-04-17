/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

// Console.WriteLine("Введите переменную m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m, n];

// Random random = new Random();
// for(int i = 0; i < m; i++)
// {
//     Console.WriteLine();
//     for(int j = 0; j < n; j++)
//     {
//         array[i,j] = random.NextDouble();
//         Console.Write(" {0:F1}", array[i,j]);
//     }
// }


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет*/

// Console.WriteLine("Введите переменную m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m, n];

// Random random = new Random();
// for(int i = 0; i < m; i++)
// {
//     Console.WriteLine();
//     for(int j = 0; j < n; j++)
//     {
//         array[i,j] = random.NextDouble();
//         Console.Write(" {0:F1}", array[i,j]);
//     }
// }

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите переменную m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

Random random = new Random();
double result = 0;
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        array[j,i] = random.Next(1, 10);
        result += array[j,i];
    }
}
Console.WriteLine();
Console.Write($"{result/m}; ");

