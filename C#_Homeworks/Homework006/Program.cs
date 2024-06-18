class Program
{
    /*  Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу. 
     *  Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.
*/
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 44, 5, 6, 7, 8, 9, 10, 11 };
        int trget = 50;
        
        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int n =0; n < arr.Length; n++)
                if (arr[i] + arr[j] + arr[n] == trget)
                {
                    Console.WriteLine($"{arr[i]} + {arr[j]} + {arr[n]}");
                }
            }
        }

       
    
    }
}