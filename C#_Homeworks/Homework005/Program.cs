class Program
{
    /*Есть лабиринт описанный в виде двумерного массива где 1 это стены, 0 - проход, 2 - искомая цель.
Пример лабиринта:
1 1 1 1 1 1 1
1 0 0 0 0 0 1
1 0 1 1 1 0 1
0 0 0 0 1 0 2
1 1 0 0 1 1 1
1 1 1 1 1 1 1
1 1 1 1 1 1 1
Напишите алгоритм определяющий наличие выхода из лабиринта и выводящий на экран координаты точки выхода если таковые имеются.
    
     Доработайте приложение поиска пути в лабиринте, но на этот раз вам нужно определить сколько всего выходов имеется в лабиринте:
*/
    static void Main(string[] args)
    {
        Stack<Tuple<int, int>> path = new Stack<Tuple<int, int>>();
        int[,] labirynth1 = new int[,]
            {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {2, 0, 0, 0, 1, 0, 2 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 },
            {1, 1, 1, 2, 1, 1, 1 }
            };

        //FindPath(3, 3);
        Console.WriteLine($"Имеем {HasExit(3, 3)} выходов");

        int HasExit(int i, int j) {
            int res = 0;

            if (labirynth1[i, j] == 0) path.Push(new Tuple<int, int>(i, j));

            while (path.Count > 0)
            {
                var current = path.Pop();
                if (labirynth1[current.Item1, current.Item2] == 2)
                {
                    Console.WriteLine($"Путь найден {current.Item1}, {current.Item2}");
                    res++;
                }
                labirynth1[current.Item1, current.Item2] = 1;

                if (current.Item1 + 1 < labirynth1.GetLength(0) && labirynth1[current.Item1 + 1, current.Item2] != 1)
                    path.Push(new(current.Item1 + 1, current.Item2));

                if (current.Item2 + 1 < labirynth1.GetLength(1) && labirynth1[current.Item1, current.Item2 + 1] != 1)
                    path.Push(new(current.Item1 + 1, current.Item2 + 1));

                if (current.Item1 > 0 && labirynth1[current.Item1 - 1, current.Item2] != 1)
                    path.Push(new(current.Item1 - 1, current.Item2));

                if (current.Item2 > 0 && labirynth1[current.Item1, current.Item2 - 1] != 1)
                    path.Push(new(current.Item1, current.Item2 - 1));
            }
            return res;
        }

        bool FindPath(int i, int j)
        {
            if (labirynth1[i, j] == 0) path.Push(new Tuple<int, int>(i, j));

            while (path.Count > 0)
            {
                var current = path.Pop();
                if (labirynth1[current.Item1, current.Item2] == 2)
                {
                    Console.WriteLine($"Путь найден {current.Item1}, {current.Item2}");
                    return true;
                }
                labirynth1[current.Item1, current.Item2] = 1;

                if (current.Item1 + 1 < labirynth1.GetLength(0) && labirynth1[current.Item1 + 1, current.Item2] != 1)
                    path.Push(new(current.Item1 + 1, current.Item2));

                if (current.Item2 + 1 < labirynth1.GetLength(1) && labirynth1[current.Item1, current.Item2 + 1] != 1)
                    path.Push(new(current.Item1 + 1, current.Item2 + 1));

                if (current.Item1 > 0 && labirynth1[current.Item1 - 1, current.Item2] != 1)
                    path.Push(new(current.Item1 - 1, current.Item2));

                if (current.Item2 > 0 && labirynth1[current.Item1, current.Item2 - 1] != 1)
                    path.Push(new(current.Item1, current.Item2 - 1));
            }

            Console.WriteLine($"Путь не найден");
            return false;

        }
    }
}
