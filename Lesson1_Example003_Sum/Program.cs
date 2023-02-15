// Написать программу сложени двух чисел
Console.WriteLine("Введите первое и второе слагаемое. Выведена их сумма");
int numberA = new Random().Next (1, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next (1, 100);
Console.WriteLine(numberB);
// Второй вариант. Можно int result = (numberA + numberB);
// Console.WriteLine(result); 
Console.WriteLine(numberA + numberB);