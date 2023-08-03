Console.Write("Введите имя пользователя:");
string userName = Console.ReadLine();

if(userName.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Првиет, ");
    Console.WriteLine(userName);
}
