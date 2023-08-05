/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

// int IsPolindrom(int num, int acc)
// {
//     while (num > 0) 
//     { 
//         acc = acc * 10 + num % 10; 
//         num /= 10; 
//     }
//     return acc;
// }

// int num = int.Parse(Console.ReadLine());
// Console.WriteLine((num == 0) || (IsPolindrom(num, 0) == num));


/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

// int size = 3;
// Console.WriteLine("Введите координаты точки A:");
// double[] DataA = new double[size];
// int i = 0;
// while (i < size)
// {
//     DataA[i] = Double.Parse(Console.ReadLine());
//     Console.WriteLine();
//     i++;
// }
// Console.WriteLine("Введите координаты точки B:");
// double[] DataB = new double[size];
// int j = 0;
// while (j < size)
// {
//     DataB[j] = Double.Parse(Console.ReadLine());
//     Console.WriteLine();
//     j++;
// }

// double[] temp = new double[size]; 

// for(int z = 0; z < size; z++)
// {
//     temp[z] = DataB[z] - DataA[z];
//     temp[z] = temp[z] * temp[z];
// }

// double distance = (double) Math.Sqrt(temp[0] + temp[1] + temp[2]);
// Console.WriteLine(distance);

/*Задача 23: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("N:");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i * i * i}, ");
}