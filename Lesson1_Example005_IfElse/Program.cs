// Приветствие пользователя-любимчика
Console.WriteLine("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "катя")
{
    Console.WriteLine("Давно не виделись, Катя!");
}
else
{
    Console.WriteLine("Приветствую, ");
    Console.WriteLine(username);
}
