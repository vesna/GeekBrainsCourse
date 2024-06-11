/*Урок 2. Условные операторы, циклы, массивы, строки, StringBuilder
Дан двумерный массив.
732
496
185
Отсортировать данные в нем по возрастанию.
123
456
789
Вывести результат на печать.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] myMatrix = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        
        Console.WriteLine("Исходный массив");
        PrintArray(myMatrix);
      

        int[] myArray = new int[9];
        int z = 0;
        for (int i = 0; i < myMatrix.GetLength(0); i++)
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
                myArray[z] = myMatrix[i, j];
                z++;
            }

        for (int i = 0; i < myArray.Length; i++) { }
        int[] result = myArray.OrderBy(i => i).ToArray();
        for (int i = 0; i < result.Length; i++) { }

        int[,] sortMyMatrix = new int[3, 3];
        int k = 0;
        for (int i = 0; i < sortMyMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < sortMyMatrix.GetLength(1); j++)
            {
                sortMyMatrix[i, j] = result[k];
                k++;
            }
        }
        Console.WriteLine("Отсортированный массив");
        PrintArray(sortMyMatrix);

    }

    public static void PrintArray(int[,] array)
    {
        for (int a = 0; a < array.GetLength(0); a++)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {
                Console.Write(array[a, b] + " ");
            }
            Console.WriteLine();
        }
    }
}
