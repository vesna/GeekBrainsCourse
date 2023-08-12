int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = random.Next(1, 10);
    }
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.GetUpperBound(1) + 1;        // количество столбцов
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" {array[i, j]}");
        }
    }
    Console.WriteLine();
}

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

// Console.WriteLine("Введите переменную m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = FillArray(m, n);
// PrintArray(array);
// int temp = 0;
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n - 1; j++)
//     {
//         if (array[i, j] < array[i, j + 1])
//         {
//             temp = array[i, j + 1];
//             array[i, j + 1] = array[i, j];
//             array[i, j] = temp;
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Результат: ");
// PrintArray(array);


/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка*/


// Console.WriteLine("Введите переменную m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = FillArray(m, n);
// PrintArray(array);
// int min = int.MaxValue;
// int result = 0;
// for (int i = 0; i < m; i++)
// {
//     int temp = 0;
//     for (int j = 0; j < n; j++)
//         temp += array[i, j];

//     if(temp < min) 
//     {
//         min = temp;
//         result = i+1;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Строка с наименьшей суммой элементов: {result}");


// /*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18*/

// Console.WriteLine("Введите переменную m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] a = FillArray(m, n);
// PrintArray(a);
// int[,] b = FillArray(m, n);
// PrintArray(b);

// int[,] r = new int[a.GetLength(0), b.GetLength(1)];
// for (int i = 0; i < a.GetLength(0); i++)
// {
//     for (int j = 0; j < b.GetLength(1); j++)
//     {
//         for (int k = 0; k < b.GetLength(0); k++)
//         {
//             r[i, j] += a[i, k] * b[k, j];
//         }
//     }
// }

// PrintArray(r);

// /*Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)*/

// Console.WriteLine("Введите переменную m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную k: ");
// int k = Convert.ToInt32(Console.ReadLine());

// Random random = new Random();
// int[,,] array = new int[m, n, k];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int x = 0; x < array.GetLength(2); x++)
//         {
//             array[i, j, x] = random.Next(10, 99);
//             Console.WriteLine($"{array[i, j, x]}({i},{j},{x})");
//         }
//     }
// }

// /*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07*/

Console.WriteLine("Введите размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m,m];
int startX = 0, startY = 0, endX = m -1, endY = m - 1, value = 1;

while(startX <= endX && startY <= endY)
{
    for(int i = startY; i <= endY; i++)
        arr[startX, i] = value++;
    startX++;

    for(int i = startX; i <= endX; i++)
        arr[i, endY] = value++;
    endY--;

    for(int i = endY; i >= startY; i--)
        arr[endX, i] = value++;
    endX--;

    for(int i = endX; i >= startX; i--)
        arr[i, startY] = value++;
    startY++;
}

PrintArray(arr);