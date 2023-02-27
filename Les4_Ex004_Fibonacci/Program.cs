// Фибоначчи - каждое слдующее число задается через предыдущее
// 1 1 2 3 5 8 13 21...
// F(1) = 1
// F(2) = 1
// F(n) = F(n-1) + F(n-2)

// int Fibonacci(int N)
// {
//     if(N == 1 || N == 2) return 1;
//     else return Fibonacci(N-1) + Fibonacci(N-2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine($"{i} = {Fibonacci(i)}");
// }

double Fibonacci(int N)
{
    if(N == 1 || N == 2) return 1;
    else return Fibonacci(N-1) + Fibonacci(N-2);
}
for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"F({i}) = {Fibonacci(i)}");
}