/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

// int size = new Random().Next(1, 100);
// int[] Data = new int[size];
// int result = 0, i = 0;;
// for (i = 0; i < size; i++)
// {
//     int number = new Random().Next(100, 999);
//     if (number % 2 == 0) result++;
//     Data[i] = number;
// }

// Console.Write("[");
// for (i = 0; i < size; i = i + 1)
// {
//     Console.Write($"{Data[i]}");
//     if (i < size - 1) Console.Write(", ");
// }
// Console.Write($"] -> {result}");


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

// int size = new Random().Next(1, 10);
// int[] Data = new int[size];
// int result = 0, i = 0;
// for (i = 0; i < size; i++)
//     Data[i] = new Random().Next(-10, 10);

// int j = 1;
// do
// {
//     result += Data[j];
//     j = j + 2;

// } while (j < size);

// Console.Write("[");
// for (i = 0; i < size; i = i + 1)
// {
//     Console.Write($"{Data[i]} ");
//     if (i < size - 1) Console.Write(", ");

// }
// Console.Write($"] -> {result}");

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int size = new Random().Next(1, 10);
int[] Data = new int[size];
int i = 0;
int min = int.MaxValue;
int max = 0;
for (i = 0; i < size; i++)
{
    int number = new Random().Next(0, 100);
    if(number < min) min = number;
    if(number > max) max = number;;
    Data[i] = number;
}


Console.Write("[");
for (i = 0; i < size; i++)
{
    Console.Write($"{Data[i]} ");
    if (i < size - 1) Console.Write(", ");

}
Console.Write($"] -> {max} - {min} = {max - min}");