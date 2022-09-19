// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

double Ackerman(double M, double N)
{
  if (M == 0)
  return N + 1;
  else if (N == 0)
  return Ackerman(M - 1, 1);
  else 
  return Ackerman(M - 1, Ackerman(M, N - 1));
}

void foo()
{
    double M, N;
    double Res;
    Console.WriteLine("Введите число М: ");
    M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    N = Convert.ToInt32(Console.ReadLine());
    Res = Ackerman(M,N);
    Console.WriteLine($"Функция Аккермана для введеных чисел равна: {Res}");

}

foo();