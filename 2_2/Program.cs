// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Res(int M, int N, int sum)
{
    sum = sum + N;
    if( N <= M)
    {
        Console.WriteLine($"Сумма равна: {sum}");
        return;
    }
    Res(M,N-1,sum);
}

void foo()
{
    int M, N;
    Console.WriteLine("Введите число М: ");
    M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    N = Convert.ToInt32(Console.ReadLine());
    Res(M,N, 0);
}

foo();