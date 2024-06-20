


using System.Collections.Generic;

class Program
{
    /*Объедините две предыдущих работы (практические работы 2 и 3): поиск файла и поиск текста в файле написав 
     * утилиту которая ищет файлы определенного расширения с указанным текстом. 
     * Рекурсивно. Пример вызова утилиты: utility.exe txt текст.*/
    //args[0] "C:\\Users\\svlig\\OneDrive\\Desktop\\Learn\\trunk\\GeekBrainsCourse\\C#_Homeworks\\Homework010"
    //args[1] "cs"
    //args[2] "List"
    static void Main(string[] args)
    {
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }
       
          List<string> list = SearchIn(args[0], args[1]);
        foreach (var item in list)
        {
            var filter = Filter(args[2], ReaderFrom(item));
            Console.WriteLine(String.Join("\n", filter));
        }
    }

    static List<string> Filter(string word, List<string> text)
    {
        return text.Where(a => a.Contains(word, StringComparison.InvariantCultureIgnoreCase))
            .Select(x => x.ToLower().Replace(word.ToLower(), word.ToUpper())).ToList();
    }

    private static List<string> SearchIn(string path, string ext)
    {
        var list = new List<string>();
        DirectoryInfo dir = new DirectoryInfo(path);
        var dirs = dir.GetDirectories();
        var files = dir.GetFiles();
        foreach (var file in files)
        {
            if (file.Extension.Contains(ext))
            {
                list.Add(file.FullName);
            }
        }
        foreach (var file in dirs)
        {
           var res = SearchIn(file.FullName, ext);
            list.AddRange(res);
        }
        return list;
    }

    public static List<string> ReaderFrom(string path)
    {
        var list = new List<string>();
        using (StreamReader sr = new StreamReader(path))
        {
            while (!sr.EndOfStream)
            {
                list.Add((string)sr.ReadLine());
            }
        }
        return list;
    }
}

