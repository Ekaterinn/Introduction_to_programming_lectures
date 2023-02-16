// Функции. Вид 1 - ничего не принимает, ничего не возвращает
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// как вызвать этот метод. указать идентификатор метода
// Method1();


// Вид 2 - что-то принимает, ничего не возвращает
// void Method2(string cat)
// {
//     Console.WriteLine(cat);
// }
// Method2(cat: "Текст сообщения");
// void Method2_1  (string cat, int count)
// {
//     int index = 0;
//     while (index < count)
//     {
//         Console.WriteLine(cat);
//         index = index + 1;
//     }
// }
// Method2_1("Текст сообщения", 5);
// Можно еще так: Method2_1(cat: "Текст сообщения", count 3);


// Вид 3 - ничего не принимают, что-то возвращают
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// Вид 4 - что-то принимают, что-то возвращают
// string Method4 (int count, string TEXT)
// {
//     int index = 0;
//     string result = String.Empty;
//     while (index < count)
//     {
//         result = result + TEXT;
//         index = index +1;
//     }
//     return result;
// }
// string res = Method4(5, "Date");
// Console.WriteLine(res);

// цикл for
// string Method4 (int count, string TEXT)
// {
//     string result = String.Empty;
//     // ниже идет инициализация счетчика int index = 0;, проверка условия index < count, интремент(увеличение)index = index +1;
//     for(int index = 0; index < count; index = index +1)
//     {
//         result = result + TEXT;
//     }
//     return result;
// }
// string res = Method4(5, "Date");
// Console.WriteLine(res);

// цикл в цикле. пример таблица умножения
for (int index = 2; index < 10; index = index +1)
{
    for (int i = 2; i < 10; i++)
    {
        // интерполяция строк (в математике способ нахождения промежуточных значений 
        // величины по имеющемуся дискретному(дробному) набору известных значений)
        Console.WriteLine($"{index} * {i} = {index*i}");
    }
    Console.WriteLine();
}