//1
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

//2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст Сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(count: 4, msg: "Текст Сообщения");

//3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//4
int Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "fwef");
Console.WriteLine(res);