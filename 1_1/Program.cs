// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void Res(int M, int N)
{
    if(N < M) return;
    Console.Write(M + ", ");
    Res(M+1, N);
}

void foo()
{
    int M, N;
    Console.WriteLine("Введите начальное значение М: ");
    M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конечное значение N: ");
    N = Convert.ToInt32(Console.ReadLine());
    Res(M,N);
}

foo();