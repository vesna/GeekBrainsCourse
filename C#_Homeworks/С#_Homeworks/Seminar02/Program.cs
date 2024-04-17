/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

// int SecondPositionNum(int num)
// {
//     return (num / 10) % 10;
// }

// Console.Write("Введите трехзначное число: ");
// int num;
// if(Int32.TryParse(Console.ReadLine(), out num))
// {
//     Console.WriteLine(SecondPositionNum(num));
// }
// else 
//      Console.WriteLine("Ошибка ввода");


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

// int ThirdDigitOfNum(int num)
// {
//     int result = -1;
//     if (num >= 100)
//     {
//         while (num > 999)
//         {
//             num = num / 10;
//         }
//         result = num % 10;
//     }
//     return result; 
// }

// Console.Write("Введите число: ");
// int num;
// if(Int32.TryParse(Console.ReadLine(), out num))
// {
//     int result = ThirdDigitOfNum(num);
//     if (result == -1)
//         Console.WriteLine("третьей цифры нет");
//     else
//         Console.WriteLine(ThirdDigitOfNum(num));
// }
// else 
//      Console.WriteLine("Ошибка ввода");


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

bool IsWeekend(int num)
{
    if (num == 6 || num == 7)
    {
        return true;
    }
    return false; 
}

Console.Write("Введите число: ");
int num;
if(Int32.TryParse(Console.ReadLine(), out num) && num > 0 && num < 8)
{
    if (IsWeekend(num))
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}
else 
     Console.WriteLine("Ошибка ввода");
