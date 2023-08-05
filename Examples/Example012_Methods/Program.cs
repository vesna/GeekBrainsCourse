// //1
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();

// //2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст Сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(count: 4, msg: "Текст Сообщения");

// //3
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// //4
// int Method4(int count, string c)
// {
//     int i = 0;
//     string result = string.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "fwef");
// Console.WriteLine(res);

int[] arr = {1, 2, 3, 4, 5, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i +1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;   
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

SelectionSort(arr);
PrintArray(arr);